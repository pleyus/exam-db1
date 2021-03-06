﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesiones_Unitam
{
    public partial class AdminGrupos : Form
    {
        public AdminGrupos()
        {
            InitializeComponent();
        }
        public void Run()
        {
            DataRowCollection D = DataBase.Select(Consultas.LISTAR_INFO_GRUPOS);
            if(D != null)
                foreach( DataRow d in D )
                {
                    ListViewItem IT = new ListViewItem();
                    IT.Text = d["Id"].ToString();
                    IT.SubItems.Add(d["Especialidad"].ToString());
                    IT.SubItems.Add(d["Nivel"].ToString());
                    IT.SubItems.Add(d["Periodo"].ToString());

                    lista.Items.Add(IT);
                }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lista.SelectedItems.Count > 0)
            {
                ListViewItem IT = lista.SelectedItems[0];
                especialidad.Text = IT.SubItems[1].Text;
                nivel.Value = int.Parse(IT.SubItems[2].Text);
                periodo.Text = IT.SubItems[3].Text;
                guardar.Enabled = true;
            }
            else            
                guardar.Enabled = false;
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            if (!DataBase.Insert(Consultas.INSERTAR_GRUPO + " ('" + especialidad.Text+ "', " + nivel.Value + ", '" + periodo.Text + "')"))
                MessageBox.Show("No se pudo insertar el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Run();
                MessageBox.Show("Grupo insertado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (!DataBase.Insert(Consultas.ACTUALIZAR_GRUPO))
                MessageBox.Show("No se pudo actualizar el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Run();
                MessageBox.Show("Grupo actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
