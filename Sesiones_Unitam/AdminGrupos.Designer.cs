namespace Sesiones_Unitam
{
    partial class AdminGrupos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.especialidad = new System.Windows.Forms.TextBox();
            this.labeln = new System.Windows.Forms.Label();
            this.periodo = new System.Windows.Forms.TextBox();
            this.nivel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(458, 265);
            this.lista.TabIndex = 0;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Especialidad";
            this.columnHeader4.Width = 227;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nivel";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Periodo";
            this.columnHeader3.Width = 80;
            // 
            // nuevo
            // 
            this.nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevo.Location = new System.Drawing.Point(372, 295);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(98, 23);
            this.nuevo.TabIndex = 1;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Especialidad";
            // 
            // especialidad
            // 
            this.especialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.especialidad.Location = new System.Drawing.Point(12, 311);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(294, 20);
            this.especialidad.TabIndex = 3;
            // 
            // labeln
            // 
            this.labeln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(101, 346);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(43, 13);
            this.labeln.TabIndex = 2;
            this.labeln.Text = "Periodo";
            // 
            // periodo
            // 
            this.periodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.periodo.Location = new System.Drawing.Point(104, 362);
            this.periodo.Name = "periodo";
            this.periodo.Size = new System.Drawing.Size(93, 20);
            this.periodo.TabIndex = 3;
            // 
            // nivel
            // 
            this.nivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nivel.Location = new System.Drawing.Point(12, 362);
            this.nivel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(74, 20);
            this.nivel.TabIndex = 4;
            this.nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel";
            // 
            // guardar
            // 
            this.guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guardar.Location = new System.Drawing.Point(372, 324);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(98, 23);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // AdminGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 392);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.periodo);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.lista);
            this.Name = "AdminGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrador de grupos";
            ((System.ComponentModel.ISupportInitialize)(this.nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox especialidad;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.TextBox periodo;
        private System.Windows.Forms.NumericUpDown nivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guardar;
    }
}