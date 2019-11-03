namespace frmAdminMenu.FormulariosEstudents
{
    partial class frmVerNotasEstudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerNotas = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 76;
            this.label1.Text = "Estudiante";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbPeriodo.Location = new System.Drawing.Point(159, 123);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(126, 21);
            this.cmbPeriodo.TabIndex = 109;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.CmbPeriodo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 108;
            this.label9.Text = "Periodo";
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.Location = new System.Drawing.Point(128, 208);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(75, 23);
            this.btnVerNotas.TabIndex = 110;
            this.btnVerNotas.Text = "Ver notas";
            this.btnVerNotas.UseVisualStyleBackColor = true;
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Sociales",
            "Matematica",
            "Lenguaje",
            "Ciencias",
            "Ingles",
            "Seminario"});
            this.cmbMateria.Location = new System.Drawing.Point(159, 163);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(126, 21);
            this.cmbMateria.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 111;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 113;
            this.label3.Text = "Año";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbAnio.Location = new System.Drawing.Point(159, 80);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(126, 21);
            this.cmbAnio.TabIndex = 114;
            // 
            // frmVerNotasEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(342, 296);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerNotas);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frmVerNotasEstudiante";
            this.Text = "Informe de notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerNotas;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAnio;
    }
}