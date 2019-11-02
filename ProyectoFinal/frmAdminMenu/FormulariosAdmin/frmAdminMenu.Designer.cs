namespace frmAdminMenu
{
    partial class frmAdminMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnGrado = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.Location = new System.Drawing.Point(205, 88);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(216, 49);
            this.btnEstudiante.TabIndex = 1;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor.Location = new System.Drawing.Point(205, 341);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(216, 49);
            this.btnProfesor.TabIndex = 2;
            this.btnProfesor.Text = "Profesor";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.BtnProfesor_Click);
            // 
            // btnGrado
            // 
            this.btnGrado.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrado.Location = new System.Drawing.Point(205, 258);
            this.btnGrado.Name = "btnGrado";
            this.btnGrado.Size = new System.Drawing.Size(216, 49);
            this.btnGrado.TabIndex = 3;
            this.btnGrado.Text = "Grado";
            this.btnGrado.UseVisualStyleBackColor = true;
            this.btnGrado.Click += new System.EventHandler(this.BtnGrado_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateria.Location = new System.Drawing.Point(205, 172);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(216, 49);
            this.btnMateria.TabIndex = 4;
            this.btnMateria.Text = "Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.BtnMateria_Click);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(622, 468);
            this.Controls.Add(this.btnMateria);
            this.Controls.Add(this.btnGrado);
            this.Controls.Add(this.btnProfesor);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminMenu";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnGrado;
        private System.Windows.Forms.Button btnMateria;
    }
}

