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
    public partial class frmIngresarNotasProfe : Form
    {
        public frmIngresarNotasProfe()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FormularioProfe.frmProfeComprobar profe = new FormularioProfe.frmProfeComprobar();
            profe.Show();
            this.Hide();
        }
    }
}
