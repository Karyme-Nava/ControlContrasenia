using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Prueba_Control
{
    public partial class AccesoCuenta : MetroForm
    {
        private PaginaPrincipal parent;
        private int usuario;
        public AccesoCuenta(PaginaPrincipal parent, int usuario)
        {
            InitializeComponent();
            this.parent = parent;
            this.usuario = usuario;
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            foreach(string u in parent.usuarios)
            {
                cbxUsuarios.Items.Add(u);
            }

            cbxUsuarios.SelectedIndex = usuario;

            if (usuario == 0)
                pbxUsuario.Image = Properties.Resources.Usuario1;
            else if (usuario == 1)
                pbxUsuario.Image = Properties.Resources.Usuario2;
            else
                pbxUsuario.Image = Properties.Resources.Usuario;
        }

        private void cbxUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            this.usuario = cbxUsuarios.SelectedIndex;
            if (usuario == 0)
                pbxUsuario.Image = Properties.Resources.Usuario1;
            else if (usuario == 1)
                pbxUsuario.Image = Properties.Resources.Usuario2;
            else
                pbxUsuario.Image = Properties.Resources.Usuario;
        }

        private void txtcContrasenia_ContraseniaIngresada(object sender, EventArgs e)
        {
            if (parent.contraseniaCorrecta(usuario, txtcContrasenia.Contrasenia))
            {
                this.Close();
                parent.ingresoCuenta();
            }
            else
            {
                epErrores.SetError(txtcContrasenia, "Revise los datos ingresados, la contraseña es incorrecta");
            }
        }

        private void AccesoCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
