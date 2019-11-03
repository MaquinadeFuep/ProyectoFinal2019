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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            frmAdminMenu menu = new frmAdminMenu();
            frmAdminEstudiante estudiante1 = new frmAdminEstudiante();
            estudiante1.Show();
            this.Hide();
            
        }

        private void BtnMateria_Click(object sender, EventArgs e)
        {
            frmAdminMenu menu = new frmAdminMenu();
            frmAdminMateria materia = new frmAdminMateria();
            materia.Show();
            this.Hide();
        }

        private void BtnGrado_Click(object sender, EventArgs e)
        {
            FormulariosAdmin.frmAdminGrado grado = new FormulariosAdmin.frmAdminGrado();
            this.Hide();
            grado.Show();
        }

        private void BtnProfesor_Click(object sender, EventArgs e)
        {
            frmAdminMenu menu = new frmAdminMenu();
            frmAdminProfesor profe = new frmAdminProfesor();
            profe.Show();
            this.Hide();
        }
    }
}
