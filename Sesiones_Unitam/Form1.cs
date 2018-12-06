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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string MOSTRAR_CLASES = "";
        public string LISTAR_GRUPOS = "";

        public string INSERTAR_GRUPO = "";
        public string GUARDAR_GRUPO = "";

        void Run()
        {
            if (grupos.SelectedIndex > 0)
            {
                DataBase.Select(MOSTRAR_CLASES);
            }
        }
        private void chkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            hora.Enabled = min.Enabled = !chkAllDay.Checked;
            Run();
        }

        private void butAdminGrupos_Click(object sender, EventArgs e)
        {
            AdminGrupos AG = new AdminGrupos();
            AG.Owner = this;
            AG.ShowDialog();
            Run();
        }

        private void now_CheckedChanged(object sender, EventArgs e)
        {
            if (now.Checked)
                dia.Enabled = hora.Enabled = min.Enabled = chkAllDay.Enabled = false;
            Run();
        }

        private void spec_CheckedChanged(object sender, EventArgs e)
        {
            if (spec.Checked)
            {
                hora.Enabled = min.Enabled = !chkAllDay.Checked;
                dia.Enabled = chkAllDay.Enabled = true;
            }
            Run();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataRowCollection D = DataBase.Select(LISTAR_GRUPOS);
            grupos.Items.Clear();
            if (D != null)
            {
                grupos.Items.Add("(Selecciona un grupo)");
                foreach (DataRow d in D)
                    grupos.Items.Add(d["Especialidad"] + " " + d["Nivel"]);
            }
            else grupos.Items.Add("(No hay grupos)");

            now.Checked = true;
            grupos.SelectedIndex = dia.SelectedIndex = hora.SelectedIndex = min.SelectedIndex = 0;
            Run();
        }
    }
}
