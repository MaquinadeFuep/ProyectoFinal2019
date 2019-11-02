namespace frmAdminMenu.FormulariosAdmin
{
    partial class frmAdminGrado
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
            this.cmbSeccionAdmin = new System.Windows.Forms.ComboBox();
            this.cmbGradoAdmin = new System.Windows.Forms.ComboBox();
            this.txtBuscaridGrado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminEliminarAdmin = new System.Windows.Forms.Button();
            this.btnAdminNuevo = new System.Windows.Forms.Button();
            this.btnModificarAdmin = new System.Windows.Forms.Button();
            this.btnAdminAgregar = new System.Windows.Forms.Button();
            this.txtIdGradoAdmin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEspecialidadAdmin = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSeccionAdmin
            // 
            this.cmbSeccionAdmin.FormattingEnabled = true;
            this.cmbSeccionAdmin.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSeccionAdmin.Location = new System.Drawing.Point(228, 181);
            this.cmbSeccionAdmin.Name = "cmbSeccionAdmin";
            this.cmbSeccionAdmin.Size = new System.Drawing.Size(126, 21);
            this.cmbSeccionAdmin.TabIndex = 71;
            this.cmbSeccionAdmin.SelectedIndexChanged += new System.EventHandler(this.CmbSeccionAdmin_SelectedIndexChanged);
            // 
            // cmbGradoAdmin
            // 
            this.cmbGradoAdmin.FormattingEnabled = true;
            this.cmbGradoAdmin.Items.AddRange(new object[] {
            "1°",
            "2°"});
            this.cmbGradoAdmin.Location = new System.Drawing.Point(228, 140);
            this.cmbGradoAdmin.Name = "cmbGradoAdmin";
            this.cmbGradoAdmin.Size = new System.Drawing.Size(126, 21);
            this.cmbGradoAdmin.TabIndex = 70;
            this.cmbGradoAdmin.SelectedIndexChanged += new System.EventHandler(this.CmbGradoAdmin_SelectedIndexChanged);
            // 
            // txtBuscaridGrado
            // 
            this.txtBuscaridGrado.Location = new System.Drawing.Point(228, 258);
            this.txtBuscaridGrado.Name = "txtBuscaridGrado";
            this.txtBuscaridGrado.Size = new System.Drawing.Size(124, 20);
            this.txtBuscaridGrado.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 26);
            this.label10.TabIndex = 68;
            this.label10.Text = "Escalafón";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 359);
            this.dataGridView1.TabIndex = 67;
            // 
            // adminEliminarAdmin
            // 
            this.adminEliminarAdmin.BackColor = System.Drawing.Color.Red;
            this.adminEliminarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEliminarAdmin.Location = new System.Drawing.Point(150, 358);
            this.adminEliminarAdmin.Name = "adminEliminarAdmin";
            this.adminEliminarAdmin.Size = new System.Drawing.Size(105, 32);
            this.adminEliminarAdmin.TabIndex = 66;
            this.adminEliminarAdmin.Text = "Eliminar";
            this.adminEliminarAdmin.UseVisualStyleBackColor = false;
            // 
            // btnAdminNuevo
            // 
            this.btnAdminNuevo.Location = new System.Drawing.Point(167, 314);
            this.btnAdminNuevo.Name = "btnAdminNuevo";
            this.btnAdminNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnAdminNuevo.TabIndex = 65;
            this.btnAdminNuevo.Text = "Nuevo";
            this.btnAdminNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificarAdmin
            // 
            this.btnModificarAdmin.Location = new System.Drawing.Point(280, 314);
            this.btnModificarAdmin.Name = "btnModificarAdmin";
            this.btnModificarAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAdmin.TabIndex = 64;
            this.btnModificarAdmin.Text = "Modificar";
            this.btnModificarAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAdminAgregar
            // 
            this.btnAdminAgregar.Location = new System.Drawing.Point(68, 314);
            this.btnAdminAgregar.Name = "btnAdminAgregar";
            this.btnAdminAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAdminAgregar.TabIndex = 63;
            this.btnAdminAgregar.Text = "Agregar";
            this.btnAdminAgregar.UseVisualStyleBackColor = true;
            // 
            // txtIdGradoAdmin
            // 
            this.txtIdGradoAdmin.Location = new System.Drawing.Point(231, 90);
            this.txtIdGradoAdmin.Name = "txtIdGradoAdmin";
            this.txtIdGradoAdmin.Size = new System.Drawing.Size(124, 20);
            this.txtIdGradoAdmin.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 26);
            this.label9.TabIndex = 61;
            this.label9.Text = "Grado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 26);
            this.label8.TabIndex = 60;
            this.label8.Text = "Sección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 59;
            this.label2.Text = "Id grado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 58;
            this.label1.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 72;
            this.label3.Text = "Especialidad";
            // 
            // cmbEspecialidadAdmin
            // 
            this.cmbEspecialidadAdmin.Enabled = false;
            this.cmbEspecialidadAdmin.FormattingEnabled = true;
            this.cmbEspecialidadAdmin.Items.AddRange(new object[] {
            "General"});
            this.cmbEspecialidadAdmin.Location = new System.Drawing.Point(226, 220);
            this.cmbEspecialidadAdmin.Name = "cmbEspecialidadAdmin";
            this.cmbEspecialidadAdmin.Size = new System.Drawing.Size(126, 21);
            this.cmbEspecialidadAdmin.TabIndex = 73;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 415);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 74;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // frmAdminGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmbEspecialidadAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSeccionAdmin);
            this.Controls.Add(this.cmbGradoAdmin);
            this.Controls.Add(this.txtBuscaridGrado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adminEliminarAdmin);
            this.Controls.Add(this.btnAdminNuevo);
            this.Controls.Add(this.btnModificarAdmin);
            this.Controls.Add(this.btnAdminAgregar);
            this.Controls.Add(this.txtIdGradoAdmin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminGrado";
            this.Text = "Grado General";
            this.Load += new System.EventHandler(this.FrmAdminGradoGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSeccionAdmin;
        private System.Windows.Forms.ComboBox cmbGradoAdmin;
        private System.Windows.Forms.TextBox txtBuscaridGrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adminEliminarAdmin;
        private System.Windows.Forms.Button btnAdminNuevo;
        private System.Windows.Forms.Button btnModificarAdmin;
        private System.Windows.Forms.Button btnAdminAgregar;
        private System.Windows.Forms.TextBox txtIdGradoAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEspecialidadAdmin;
        private System.Windows.Forms.Button btnAtras;
    }
}