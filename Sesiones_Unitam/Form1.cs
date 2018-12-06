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
        

        void Run()
        {
            if (grupos.SelectedIndex > 0)
            {
                DataBase.Select(Consultas.MOSTRAR_CLASES);
            }
        }
        private void chkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            hora.Enabled = !todo_el_dia.Checked;
            Run();
        }

        private void butAdminGrupos_Click(object sender, EventArgs e)
        {
            AdminGrupos AG = new AdminGrupos();
            AG.ShowDialog();
            Run();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            DataRowCollection D = DataBase.Select(Consultas.LISTAR_GRUPOS);
            grupos.Items.Clear();
            if (D != null)
            {
                grupos.Items.Add("(Selecciona un grupo)");
                foreach (DataRow d in D)
                    grupos.Items.Add(d["Especialidad"] + " " + d["Nivel"]);
            }
            else grupos.Items.Add("(No hay grupos)");

            grupos.SelectedIndex = 0;
            ahora_Click(null, null);
            
            Run();
        }

        private void ahora_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;

            hora.Value = Date;
            dia.SelectedIndex = ((int)Date.DayOfWeek);

            if (sender != null)
            {
                todo_el_dia.Checked = false;
                Run();
            }
        }

        private void ButAdminProfesores_Click(object sender, EventArgs e)
        {
            AdminMaestros AM = new AdminMaestros();
            AM.ShowDialog();
            Run();
        }

        private void butAdminMaterias_Click(object sender, EventArgs e)
        {
            AdminMaterias AM = new AdminMaterias();
            AM.ShowDialog();
            Run();
        }

        private void butAdminClases_Click(object sender, EventArgs e)
        {
            AdminSesiones AS = new AdminSesiones();
            AS.ShowDialog();
            Run();
        }
    }
}
