namespace frmAdminMenu.FormularioProfe
{
    partial class FrmIngresoNotasProfe
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
            this.cmbSeccionProfe = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIngresarProfe = new System.Windows.Forms.Button();
            this.txtIdGradoprofe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMateriaProfe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEscalafonProfesorNotas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSeccionProfe
            // 
            this.cmbSeccionProfe.FormattingEnabled = true;
            this.cmbSeccionProfe.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSeccionProfe.Location = new System.Drawing.Point(234, 184);
            this.cmbSeccionProfe.Name = "cmbSeccionProfe";
            this.cmbSeccionProfe.Size = new System.Drawing.Size(126, 21);
            this.cmbSeccionProfe.TabIndex = 87;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 359);
            this.dataGridView1.TabIndex = 83;
            // 
            // btnIngresarProfe
            // 
            this.btnIngresarProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarProfe.Location = new System.Drawing.Point(153, 360);
            this.btnIngresarProfe.Name = "btnIngresarProfe";
            this.btnIngresarProfe.Size = new System.Drawing.Size(102, 61);
            this.btnIngresarProfe.TabIndex = 79;
            this.btnIngresarProfe.Text = "Ingresar Notas";
            this.btnIngresarProfe.UseVisualStyleBackColor = true;
            // 
            // txtIdGradoprofe
            // 
            this.txtIdGradoprofe.Location = new System.Drawing.Point(234, 101);
            this.txtIdGradoprofe.Name = "txtIdGradoprofe";
            this.txtIdGradoprofe.Size = new System.Drawing.Size(124, 20);
            this.txtIdGradoprofe.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 26);
            this.label8.TabIndex = 76;
            this.label8.Text = "Sección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 75;
            this.label2.Text = "Id grado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 74;
            this.label1.Text = "Profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 26);
            this.label4.TabIndex = 90;
            this.label4.Text = "Grados a los que imparte clases";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 26);
            this.label5.TabIndex = 91;
            this.label5.Text = "Seleccionar a que grado desea agregar notas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 92;
            this.label6.Text = "Materia";
            // 
            // cmbMateriaProfe
            // 
            this.cmbMateriaProfe.FormattingEnabled = true;
            this.cmbMateriaProfe.Items.AddRange(new object[] {
            "Sociales",
            "Matematica",
            "Lenguaje",
            "Ciencias"});
            this.cmbMateriaProfe.Location = new System.Drawing.Point(234, 137);
            this.cmbMateriaProfe.Name = "cmbMateriaProfe";
            this.cmbMateriaProfe.Size = new System.Drawing.Size(126, 21);
            this.cmbMateriaProfe.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 94;
            this.label7.Text = "Escalafón";
            // 
            // txtEscalafonProfesorNotas
            // 
            this.txtEscalafonProfesorNotas.Location = new System.Drawing.Point(233, 231);
            this.txtEscalafonProfesorNotas.Name = "txtEscalafonProfesorNotas";
            this.txtEscalafonProfesorNotas.Size = new System.Drawing.Size(124, 20);
            this.txtEscalafonProfesorNotas.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 96;
            this.label9.Text = "Periodo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(234, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 97;
            // 
            // FrmIngresoNotasProfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEscalafonProfesorNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMateriaProfe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSeccionProfe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIngresarProfe);
            this.Controls.Add(this.txtIdGradoprofe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresoNotasProfe";
            this.Text = "FrmIngresoNotasProfe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSeccionProfe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIngresarProfe;
        private System.Windows.Forms.TextBox txtIdGradoprofe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMateriaProfe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEscalafonProfesorNotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}