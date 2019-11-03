namespace frmAdminMenu
{
    partial class frmAdminMateria
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
            this.cmbTipoMateria = new System.Windows.Forms.ComboBox();
            this.txtHorasSemanales = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusquedaID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusquedaNombreApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoMateria
            // 
            this.cmbTipoMateria.Enabled = false;
            this.cmbTipoMateria.FormattingEnabled = true;
            this.cmbTipoMateria.Items.AddRange(new object[] {
            "Basica",
            "Seminario"});
            this.cmbTipoMateria.Location = new System.Drawing.Point(223, 227);
            this.cmbTipoMateria.Name = "cmbTipoMateria";
            this.cmbTipoMateria.Size = new System.Drawing.Size(126, 21);
            this.cmbTipoMateria.TabIndex = 71;
            // 
            // txtHorasSemanales
            // 
            this.txtHorasSemanales.Location = new System.Drawing.Point(223, 188);
            this.txtHorasSemanales.Name = "txtHorasSemanales";
            this.txtHorasSemanales.Size = new System.Drawing.Size(124, 20);
            this.txtHorasSemanales.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 26);
            this.label10.TabIndex = 68;
            this.label10.Text = "Tipo de materia";
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(427, 81);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.Size = new System.Drawing.Size(364, 359);
            this.dgvMateria.TabIndex = 67;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(129, 485);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 32);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(146, 441);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(259, 441);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 64;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 441);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 63;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Location = new System.Drawing.Point(223, 96);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.Size = new System.Drawing.Size(124, 20);
            this.txtIdMateria.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 26);
            this.label9.TabIndex = 61;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 26);
            this.label8.TabIndex = 60;
            this.label8.Text = "Horas Semanales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 59;
            this.label2.Text = "Id Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 58;
            this.label1.Text = "Materia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 73;
            this.label3.Text = "Buscar materia por ID";
            // 
            // txtBusquedaID
            // 
            this.txtBusquedaID.Location = new System.Drawing.Point(281, 336);
            this.txtBusquedaID.Name = "txtBusquedaID";
            this.txtBusquedaID.Size = new System.Drawing.Size(124, 20);
            this.txtBusquedaID.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 26);
            this.label4.TabIndex = 75;
            this.label4.Text = "Buscar materia por Nombre";
            // 
            // txtBusquedaNombreApellido
            // 
            this.txtBusquedaNombreApellido.Location = new System.Drawing.Point(281, 380);
            this.txtBusquedaNombreApellido.Name = "txtBusquedaNombreApellido";
            this.txtBusquedaNombreApellido.Size = new System.Drawing.Size(124, 20);
            this.txtBusquedaNombreApellido.TabIndex = 76;
            // 
            // frmAdminMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(822, 542);
            this.Controls.Add(this.txtBusquedaNombreApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBusquedaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoMateria);
            this.Controls.Add(this.txtHorasSemanales);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdMateria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminMateria";
            this.Text = " Materia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoMateria;
        private System.Windows.Forms.TextBox txtHorasSemanales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusquedaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusquedaNombreApellido;
    }
}