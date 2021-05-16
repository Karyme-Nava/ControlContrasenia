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
    public partial class PaginaPrincipal : MetroForm
    {
        public List<string> usuarios;
        private List<string> contrasenias;

        public PaginaPrincipal()
        {
            InitializeComponent();
            usuarios = new List<string>();
            contrasenias = new List<string>();
            iniciarUsuariosPredeterminados();
        }
        private void iniciarUsuariosPredeterminados()
        {
            usuarios.Add("Usuario 1");
            contrasenias.Add("Usuario1*");
            usuarios.Add("Usuario 2");
            contrasenias.Add("Usuario2*");
        }

        private int usuarioRegistrado(String cadena)
        {
            for(int i=0; i<usuarios.Count; i++)
            {
                if (usuarios[i].Equals(cadena))
                    return i;
            }
            return -1;
        }

        private void txtcContrasenia_CambioEnContrasenia(object sender, EventArgs e)
        {
            if (txtcContrasenia.ContraseniaValida)
            {
                lblValidar.Text = "Válida";
            }
            else
            {
                lblValidar.Text = "No válida";
            }
        }

        public void ingresoCuenta()
        {
            this.Visible = true;
            MessageBox.Show("Se ha podido ingresar exitosamente a la cuenta", "Cuenta ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public bool contraseniaCorrecta(int usuario, string contrasenia)
        {
            return contrasenia.Equals(contrasenias[usuario]);
        }

        private void pbxUsuario1_Click(object sender, EventArgs e)
        {
            AccesoCuenta ventanaAC = new AccesoCuenta(this, 0);
            ventanaAC.Visible = true;
            this.Visible = false;
        }

        private void pbxUsuario2_Click(object sender, EventArgs e)
        {
            AccesoCuenta ventanaAC = new AccesoCuenta(this, 1);
            ventanaAC.Visible = true;
            this.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingreso();
        }

        private void txtcContrasenia_ContraseniaIngresada(object sender, EventArgs e)
        {
            ingreso();
        }

        private void ingreso()
        {
            int registro = usuarioRegistrado(txtUsuario.Text);
            if (registro != -1)
            {
                if (txtcContrasenia.Contrasenia.Equals(contrasenias[registro]))
                {
                    epErrores.SetError(txtcContrasenia, "");
                    ingresoCuenta();
                }
                else
                {
                    epErrores.SetError(txtcContrasenia, "El usuario ya ha sido registrado, la contraseña ingresada no es correcta");
                }
            }
            else if (txtcContrasenia.ContraseniaValida)
            {
                epErrores.SetError(txtcContrasenia, "");
                DialogResult res = MessageBox.Show("El usuario ingresado es nuevo, ¿desea crear un nuevo usuario con los datos especificados?", "Nuevo registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    usuarios.Add(txtUsuario.Text);
                    contrasenias.Add(txtcContrasenia.Contrasenia);
                    txtUsuario.Text = "";
                    txtcContrasenia.Contrasenia = "";
                    MessageBox.Show("El registro fue completado de forma exitosa", "Registro finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                epErrores.SetError(txtcContrasenia, "La contraseña no es válida, no cumple con los requerimientos mínimos (8 caracteres que deben incluir minúsculas, mayúsculas, números y símbolos !?*-_)");
            }
        }
    }
}
