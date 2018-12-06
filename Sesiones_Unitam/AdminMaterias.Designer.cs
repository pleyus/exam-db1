namespace Sesiones_Unitam
{
    partial class AdminMaterias
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
            this.docente = new System.Windows.Forms.ComboBox();
            this.materia = new System.Windows.Forms.TextBox();
            this.labeln = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nuevo = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // docente
            // 
            this.docente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docente.FormattingEnabled = true;
            this.docente.Location = new System.Drawing.Point(150, 284);
            this.docente.Name = "docente";
            this.docente.Size = new System.Drawing.Size(146, 21);
            this.docente.TabIndex = 3;
            // 
            // materia
            // 
            this.materia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materia.Location = new System.Drawing.Point(12, 285);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(132, 20);
            this.materia.TabIndex = 2;
            // 
            // labeln
            // 
            this.labeln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(147, 268);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(48, 13);
            this.labeln.TabIndex = 19;
            this.labeln.Text = "Docente";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Materia";
            // 
            // nuevo
            // 
            this.nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevo.Location = new System.Drawing.Point(537, 282);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(98, 23);
            this.nuevo.TabIndex = 5;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(623, 241);
            this.lista.TabIndex = 1;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grupo";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Materia";
            this.columnHeader4.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Docente";
            this.columnHeader3.Width = 222;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Grupo";
            // 
            // grupo
            // 
            this.grupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grupo.FormattingEnabled = true;
            this.grupo.Location = new System.Drawing.Point(302, 284);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(211, 21);
            this.grupo.TabIndex = 4;
            // 
            // AdminMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 317);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.docente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.lista);
            this.Name = "AdminMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminMaterias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox docente;
        private System.Windows.Forms.TextBox materia;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox grupo;
    }
}