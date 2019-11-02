using System;
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
    public partial class frmAdminEstudiante : Form
    {
        public frmAdminEstudiante()
        {
            InitializeComponent();
            cmbGeneroEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradoEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeccionEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TxtNIE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbGradoEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAdminEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
