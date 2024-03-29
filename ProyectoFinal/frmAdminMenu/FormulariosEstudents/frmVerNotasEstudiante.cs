﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAdminMenu.FormulariosEstudents
{
    public partial class frmVerNotasEstudiante : Form
    {
        public frmVerNotasEstudiante()
        {
            InitializeComponent();
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AlumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void CmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerNotas_Click(object sender, EventArgs e)
        {
            FormulariosEstudents.frmInformeNotasEstudiante informe = new FormulariosEstudents.frmInformeNotasEstudiante();
            informe.Show();
            this.Hide();

        }

        private void CmbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
