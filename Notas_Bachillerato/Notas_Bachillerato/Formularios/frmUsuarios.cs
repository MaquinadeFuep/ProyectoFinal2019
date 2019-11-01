using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Notas_Bachillerato.Clases;

namespace Notas_Bachillerato.Formularios
{
    public partial class frmUsuarios : Form
    {

        Transacciones t = new Transacciones();
        Usuarios user = new Usuarios();

        public void cargar()
        {
            this.gridDatos.DataSource = null;
            this.gridDatos.DataSource = t.consultar("Usuario");
        }

        public frmUsuarios()
        {
            InitializeComponent();
            cargar();
        }

        private void setiar()
        {
            user.NombreUsuario = this.txtNombUsuario.Text;
            user.IdDocente = int.Parse(this.txtIdDocente.Text);
            user.Contra = this.txtContra.Text;
            user.IdTipo = int.Parse(this.cmbTipoUsuario.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            setiar();

            if (t.insertar(user, "Usuario"))
            {
                MessageBox.Show("Usuario agregado exitosamente");
                cargar();
            }
            else
            {
                MessageBox.Show("¡Error!");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            setiar();

            if (t.modificar(user, "Usuario"))
            {
                MessageBox.Show("Usuario modificado exitosamente");
                cargar();
            }
            else
            {
                MessageBox.Show("¡Error!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            setiar();

            if (MessageBox.Show(this, "¿Está seguro de eliminar esto?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (t.eliminar(this.user, "Usuario"))
                {
                    MessageBox.Show("Usuario eliminado exitosamente");
                    cargar();
                }
                else
                {
                    MessageBox.Show("No se borró el usuario seleccionado");
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = null;
            gridDatos.DataSource = t.filtrar("Usuario", cmbCampos.Text, txtCriterio.Text);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cargar();
            this.txtCriterio.Clear();
            cmbCampos.Text = null;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
