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
    public partial class AdminMaterias : Form
    {
        public AdminMaterias()
        {
            InitializeComponent();
        }
        Dictionary<int, string> Docentes = new Dictionary<int, string>();
        Dictionary<int, string> Grupos = new Dictionary<int, string>();

        void Run()
        {
            Docentes.Clear();
            DataRowCollection R = DataBase.Select(Consultas.LISTAR_DOCENTES);
            foreach (DataRow r in R)
                Docentes.Add(int.Parse(r["Id"].ToString()), r["Nombre"].ToString() + r["Apellido"].ToString());

            Grupos.Clear();
            R = DataBase.Select(Consultas.LISTAR_GRUPOS);
            foreach (DataRow r in R)
                Docentes.Add(int.Parse(r["Id"].ToString()), 
                    r["Especialidad"].ToString() + " " + Consultas.Roman(int.Parse(r["Nivel"].ToString())));

            lista.Items.Clear();
            R = DataBase.Select(Consultas.LISTAR_INFO_MATERIAS);
            foreach(DataRow r in R)
            {
                ListViewItem IT = new ListViewItem();
                IT.Text = r["Id"].ToString();
                IT.SubItems.Add( 
                    Grupos[int.Parse(r["IdGrupo"].ToString())]
                    );
                IT.SubItems.Add(
                    Docentes[int.Parse(r["IdDocente"].ToString())]
                    );
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count > 0)
            {
                ListViewItem IT = lista.SelectedItems[0];

                for (int i = 0; i < grupo.Items.Count; i++)
                    if (grupo.Items[i].ToString() == IT.SubItems[1].Text)
                    {
                        grupo.SelectedIndex = i;
                        break;
                    }

                materia.Text = IT.SubItems[2].Text;

                for (int i = 0; i < docente.Items.Count; i++)
                    if (docente.Items[i].ToString() == IT.SubItems[3].Text)
                    {
                        docente.SelectedIndex = i;
                        break;
                    }
            }
        }

        string getKey(Dictionary<int, string> Dic, string val)
        {
            if (Dic.ContainsValue(val))
            {
                foreach (KeyValuePair<int, string> V in Dic)
                    if (V.Value == val)
                        return V.Key.ToString();
            }
            return "0";
        }
        private void nuevo_Click(object sender, EventArgs e)
        {
            if (!DataBase.Insert(Consultas.INSERTAR_MATERIA + " ('" + materia.Text + "', " + getKey(Grupos, grupo.SelectedItem.ToString()) + ", " + getKey(Docentes, docente.SelectedItem.ToString()) + ")"))
                MessageBox.Show("No se pudo insertar el grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Run();
                MessageBox.Show("Grupo insertado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
