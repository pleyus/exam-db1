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
    public partial class AdminMaestros : Form
    {
        public AdminMaestros()
        {
            InitializeComponent();
        }
        public void Run()
        {
            DataRowCollection D = DataBase.Select(Consultas.LISTAR_INFO_DOCENTES);
            if (D != null)
                foreach (DataRow d in D)
                {
                    ListViewItem IT = new ListViewItem();
                    IT.Text = d["Id"].ToString();
                    IT.SubItems.Add(d["Nombre"].ToString());
                    IT.SubItems.Add(d["Apellido"].ToString());
                    IT.SubItems.Add(d["Edad"].ToString());
                    IT.SubItems.Add(d["Sexo"].ToString());

                    lista.Items.Add(IT);
                }
        }
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count > 0)
            {
                ListViewItem IT = lista.SelectedItems[0];
                nombre.Text = IT.SubItems[1].Text;
                apellidos.Text = IT.SubItems[2].Text;
                edad.Value = int.Parse(IT.SubItems[3].Text);

                string sex = IT.SubItems[4].Text;
                sexo.SelectedIndex = (
                    sex == "Mujer"
                    ? 1
                    : (sex == "Hombre"
                        ? 2
                        : 0));
                
                guardar.Enabled = true;
            }
            else
                guardar.Enabled = false;
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            if (!DataBase.Insert(Consultas.INSERTAR_DOCENTE + " ('" + nombre.Text + "', '" + apellidos.Text + "', " + edad.Value + ", " + sexo.SelectedIndex + ")"))
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
