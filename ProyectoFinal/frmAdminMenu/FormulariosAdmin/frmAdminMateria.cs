﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAdminMenu
{
    public partial class frmAdminMateria : Form
    {
        public frmAdminMateria()
        {
            InitializeComponent();
            cmbTipoMateria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            frmAdminMenu menu = new frmAdminMenu();
            menu.Show();
            this.Hide();
        }
    }
}
