using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    /// <summary>
    /// Permite al usuario ingresar un texto, contiene las características básicas de un campo para ingresar una contraseña.
    /// </summary>
    [Description("Permite al usuario ingresar un texto, contiene las características básicas de un campo para ingresar una contraseña.")]
    public partial class TextBoxContrasenia : UserControl
    {
        private string contrasenia;
        private bool visibilidadBotonIngresar;
        private bool contraseniaVisible;
        private bool contraseniaValida;
        private Regex er;

        /// <summary>
        /// Se produce cuando se termina de ingresar la contraseña y se presiona la tecla Enter dentro del 
        /// área de texto o al dar clic sobre el botón con flecha.
        /// </summary>
        [Description("Se produce cuando se termina de ingresar la contraseña y se presiona la tecla Enter dentro del área de texto o al dar clic sobre el botón con flecha."), 
            Category("Acción")]
        public event EventHandler ContraseniaIngresada;

        /// <summary>
        /// Se produce cuando la propiedad Contrasenia cambia.
        /// </summary>
        [Description("Se produce cuando la propiedad Contrasenia cambia."), Category("La propiedad cambió")]
        public event EventHandler CambioEnContrasenia;

        /// <summary>
        /// Obtiene o establece el texto de la contraseña dentro del control.
        /// </summary>
        [Description("Obtiene o establece el texto de la contraseña dentro del control."), 
            Category("Apariencia")]
        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }
            set
            {
                contrasenia = txtContrasenia.Text = value;
            }
        }

        /// <summary>
        /// Obtiene o establece un valor que indica si se muestra el botón con flecha que permite
        /// guardar la contraseña.
        /// </summary>
        [Description("Obtiene o establece un valor que indica si se muestra el botón con flecha que permite guardar la contraseña."), 
            Category("Diseño")]
        public bool VisibilidadBotonIngresar
        {
            get
            {
                return visibilidadBotonIngresar;
            }
            set
            {
                visibilidadBotonIngresar = btnIngresar.Visible = value;
            }
        }

        /// <summary>
        /// Obtiene un valor que indica si la contraseña cumple con los requerimientos mínimos (8 caracteres 
        /// que deben incluir minúsculas, mayúsculas, números y símbolos !?*_).
        /// </summary>
        [Description("Obtiene un valor que indica si la contraseña cumple con los requerimientos mínimos (8 caracteres que deben incluir minúsculas, mayúsculas, números y símbolos !?*_)."), 
            Category("Validaciones")]
        public bool ContraseniaValida
        {
            get
            {
                return er.IsMatch(txtContrasenia.Text);
            }
        }

        /// <summary>
        /// Inicializa una instancia del control TextBoxContrasenia
        /// </summary>
        public TextBoxContrasenia()
        {
            InitializeComponent();
            contrasenia = "";
            VisibilidadBotonIngresar = true;
            contraseniaVisible = false;
            er = new Regex("^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[!?*_])[a-zA-Z0-9!?*_]{8,}$");
        }

        private void pbxVisibilidad_Click(object sender, EventArgs e)
        {
            pbxVisibilidad.Focus();
            if (contraseniaVisible)
            {
                pbxVisibilidad.Image = Properties.Resources.Ojo_visible;
                txtContrasenia.UseSystemPasswordChar = true;
                contraseniaVisible = false;
            } else
            {
                pbxVisibilidad.Image = Properties.Resources.Ojo_no_visible;
                txtContrasenia.UseSystemPasswordChar = false;
                contraseniaVisible = true;
            }
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ContraseniaIngresada?.Invoke(this, null);
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            Contrasenia = txtContrasenia.Text;
            CambioEnContrasenia?.Invoke(this, null);
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ContraseniaIngresada?.Invoke(this, null);
            } else if ((int)e.KeyCode == (int)Keys.CapsLock)
            {
                e.SuppressKeyPress = true;
                if (System.Windows.Forms.Control.IsKeyLocked(Keys.CapsLock))
                    lblMayusculas.Text = "La tecla Bloq Mayus está activada";
                else
                    lblMayusculas.Text = "";
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Control.IsKeyLocked(Keys.CapsLock))
                lblMayusculas.Text = "La tecla Bloq Mayus está activada";
            else
                lblMayusculas.Text = "";
        }

    }
}
