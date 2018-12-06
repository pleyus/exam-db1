namespace Sesiones_Unitam
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butAdminGrupos = new System.Windows.Forms.Button();
            this.ButAdminProfesores = new System.Windows.Forms.Button();
            this.butAdminMaterias = new System.Windows.Forms.Button();
            this.butAdminClases = new System.Windows.Forms.Button();
            this.grupos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.todo_el_dia = new System.Windows.Forms.CheckBox();
            this.dia = new System.Windows.Forms.ComboBox();
            this.ahora = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(634, 355);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Entrada";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Salida";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Grupo";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Materia";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Profesor";
            this.columnHeader3.Width = 166;
            // 
            // butAdminGrupos
            // 
            this.butAdminGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butAdminGrupos.Location = new System.Drawing.Point(12, 413);
            this.butAdminGrupos.Name = "butAdminGrupos";
            this.butAdminGrupos.Size = new System.Drawing.Size(122, 33);
            this.butAdminGrupos.TabIndex = 1;
            this.butAdminGrupos.Text = "Administrar grupos";
            this.butAdminGrupos.UseVisualStyleBackColor = true;
            this.butAdminGrupos.Click += new System.EventHandler(this.butAdminGrupos_Click);
            // 
            // ButAdminProfesores
            // 
            this.ButAdminProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButAdminProfesores.Location = new System.Drawing.Point(140, 413);
            this.ButAdminProfesores.Name = "ButAdminProfesores";
            this.ButAdminProfesores.Size = new System.Drawing.Size(122, 33);
            this.ButAdminProfesores.TabIndex = 1;
            this.ButAdminProfesores.Text = "Administrar profesores";
            this.ButAdminProfesores.UseVisualStyleBackColor = true;
            this.ButAdminProfesores.Click += new System.EventHandler(this.ButAdminProfesores_Click);
            // 
            // butAdminMaterias
            // 
            this.butAdminMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butAdminMaterias.Location = new System.Drawing.Point(268, 413);
            this.butAdminMaterias.Name = "butAdminMaterias";
            this.butAdminMaterias.Size = new System.Drawing.Size(122, 33);
            this.butAdminMaterias.TabIndex = 1;
            this.butAdminMaterias.Text = "Administrar materias";
            this.butAdminMaterias.UseVisualStyleBackColor = true;
            this.butAdminMaterias.Click += new System.EventHandler(this.butAdminMaterias_Click);
            // 
            // butAdminClases
            // 
            this.butAdminClases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butAdminClases.Location = new System.Drawing.Point(396, 413);
            this.butAdminClases.Name = "butAdminClases";
            this.butAdminClases.Size = new System.Drawing.Size(122, 33);
            this.butAdminClases.TabIndex = 1;
            this.butAdminClases.Text = "Administrar clases";
            this.butAdminClases.UseVisualStyleBackColor = true;
            this.butAdminClases.Click += new System.EventHandler(this.butAdminClases_Click);
            // 
            // grupos
            // 
            this.grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grupos.FormattingEnabled = true;
            this.grupos.Location = new System.Drawing.Point(12, 25);
            this.grupos.Name = "grupos";
            this.grupos.Size = new System.Drawing.Size(308, 21);
            this.grupos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mostrar clases de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia y hora";
            // 
            // todo_el_dia
            // 
            this.todo_el_dia.AutoSize = true;
            this.todo_el_dia.Location = new System.Drawing.Point(487, 27);
            this.todo_el_dia.Name = "todo_el_dia";
            this.todo_el_dia.Size = new System.Drawing.Size(79, 17);
            this.todo_el_dia.TabIndex = 6;
            this.todo_el_dia.Text = "Todo el dia";
            this.todo_el_dia.UseVisualStyleBackColor = true;
            this.todo_el_dia.CheckedChanged += new System.EventHandler(this.chkAllDay_CheckedChanged);
            // 
            // dia
            // 
            this.dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dia.FormattingEnabled = true;
            this.dia.Items.AddRange(new object[] {
            "Domingo",
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.dia.Location = new System.Drawing.Point(333, 25);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(72, 21);
            this.dia.TabIndex = 2;
            // 
            // ahora
            // 
            this.ahora.Location = new System.Drawing.Point(572, 23);
            this.ahora.Name = "ahora";
            this.ahora.Size = new System.Drawing.Size(75, 23);
            this.ahora.TabIndex = 7;
            this.ahora.Text = "Ahora";
            this.ahora.UseVisualStyleBackColor = true;
            this.ahora.Click += new System.EventHandler(this.ahora_Click);
            // 
            // hora
            // 
            this.hora.CustomFormat = "HH:mm";
            this.hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hora.Location = new System.Drawing.Point(411, 25);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(70, 20);
            this.hora.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 460);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.ahora);
            this.Controls.Add(this.todo_el_dia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.grupos);
            this.Controls.Add(this.butAdminClases);
            this.Controls.Add(this.butAdminMaterias);
            this.Controls.Add(this.ButAdminProfesores);
            this.Controls.Add(this.butAdminGrupos);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button butAdminGrupos;
        private System.Windows.Forms.Button ButAdminProfesores;
        private System.Windows.Forms.Button butAdminMaterias;
        private System.Windows.Forms.Button butAdminClases;
        private System.Windows.Forms.ComboBox grupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox todo_el_dia;
        private System.Windows.Forms.ComboBox dia;
        private System.Windows.Forms.Button ahora;
        private System.Windows.Forms.DateTimePicker hora;
    }
}

