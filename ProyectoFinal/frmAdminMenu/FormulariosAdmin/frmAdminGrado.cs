using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAdminMenu.FormulariosAdmin
{
    public partial class frmAdminGrado : Form
    {
        public frmAdminGrado()
        {
            InitializeComponent();
            cmbEspecialidadAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradoAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeccionAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmAdminGradoGeneral_Load(object sender, EventArgs e)
        {

        }

        private void CmbSeccionAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbGradoAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
