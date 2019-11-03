using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAdminMenu.FormularioProfe
{
    public partial class frmProfeComprobar : Form
    {
        public frmProfeComprobar()
        {
            InitializeComponent();
            cmbMateriaProfe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeccionProfe.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnIngresarProfe_Click(object sender, EventArgs e)
        {
            FormularioProfe.frmIngresarNotasProfe instanciaProfe = new FormularioProfe.frmIngresarNotasProfe ();
            instanciaProfe.Show();
            this.Hide();
        }

        private void CmbMateriaProfe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
