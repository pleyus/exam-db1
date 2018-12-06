using System;
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
            {
                especialidad.Text = "";
                nivel.Value = 1;
                periodo.Text = "";
                guardar.Enabled = false;
            }

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            if (!DataBase.Insert(((Form1)Owner).INSERTAR_GRUPO))
                MessageBox.Show("No se pudo insertar el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (!DataBase.Insert(((Form1)Owner).GUARDAR_GRUPO))
                MessageBox.Show("No se pudo actualizar el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
