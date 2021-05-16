
namespace Prueba_Control
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblIniciosRecientes = new MetroFramework.Controls.MetroLabel();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.lblUsuario1 = new MetroFramework.Controls.MetroLabel();
            this.lblUsuario2 = new MetroFramework.Controls.MetroLabel();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lblContrasenia = new MetroFramework.Controls.MetroLabel();
            this.txtcContrasenia = new Control.TextBoxContrasenia();
            this.lblIndicacion1 = new MetroFramework.Controls.MetroLabel();
            this.lblIndicacion2 = new MetroFramework.Controls.MetroLabel();
            this.pbxUsuario2 = new System.Windows.Forms.PictureBox();
            this.pbxUsuario1 = new System.Windows.Forms.PictureBox();
            this.lblValidar = new MetroFramework.Controls.MetroLabel();
            this.epErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciosRecientes
            // 
            this.lblIniciosRecientes.AutoSize = true;
            this.lblIniciosRecientes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIniciosRecientes.Location = new System.Drawing.Point(23, 60);
            this.lblIniciosRecientes.Name = "lblIniciosRecientes";
            this.lblIniciosRecientes.Size = new System.Drawing.Size(207, 25);
            this.lblIniciosRecientes.TabIndex = 2;
            this.lblIniciosRecientes.Text = "Inicios de sesión recientes";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Location = new System.Drawing.Point(405, 278);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 32);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblUsuario1
            // 
            this.lblUsuario1.AutoSize = true;
            this.lblUsuario1.Location = new System.Drawing.Point(68, 284);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(62, 19);
            this.lblUsuario1.TabIndex = 5;
            this.lblUsuario1.Text = "Usuario 1";
            // 
            // lblUsuario2
            // 
            this.lblUsuario2.AutoSize = true;
            this.lblUsuario2.Location = new System.Drawing.Point(231, 284);
            this.lblUsuario2.Name = "lblUsuario2";
            this.lblUsuario2.Size = new System.Drawing.Size(64, 19);
            this.lblUsuario2.TabIndex = 6;
            this.lblUsuario2.Text = "Usuario 2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(382, 130);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(382, 152);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(123, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(382, 192);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(75, 19);
            this.lblContrasenia.TabIndex = 9;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // txtcContrasenia
            // 
            this.txtcContrasenia.BackColor = System.Drawing.Color.White;
            this.txtcContrasenia.Contrasenia = "";
            this.txtcContrasenia.Location = new System.Drawing.Point(382, 214);
            this.txtcContrasenia.MaximumSize = new System.Drawing.Size(300, 38);
            this.txtcContrasenia.MinimumSize = new System.Drawing.Size(179, 38);
            this.txtcContrasenia.Name = "txtcContrasenia";
            this.txtcContrasenia.Size = new System.Drawing.Size(179, 38);
            this.txtcContrasenia.TabIndex = 1;
            this.txtcContrasenia.VisibilidadBotonIngresar = false;
            this.txtcContrasenia.ContraseniaIngresada += new System.EventHandler(this.txtcContrasenia_ContraseniaIngresada);
            this.txtcContrasenia.CambioEnContrasenia += new System.EventHandler(this.txtcContrasenia_CambioEnContrasenia);
            // 
            // lblIndicacion1
            // 
            this.lblIndicacion1.AutoSize = true;
            this.lblIndicacion1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblIndicacion1.Location = new System.Drawing.Point(26, 103);
            this.lblIndicacion1.Name = "lblIndicacion1";
            this.lblIndicacion1.Size = new System.Drawing.Size(104, 15);
            this.lblIndicacion1.TabIndex = 4;
            this.lblIndicacion1.Text = "Haz clic en una foto";
            // 
            // lblIndicacion2
            // 
            this.lblIndicacion2.AutoSize = true;
            this.lblIndicacion2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblIndicacion2.Location = new System.Drawing.Point(382, 103);
            this.lblIndicacion2.Name = "lblIndicacion2";
            this.lblIndicacion2.Size = new System.Drawing.Size(131, 15);
            this.lblIndicacion2.TabIndex = 7;
            this.lblIndicacion2.Text = "Ingresa un nuevo usuario";
            // 
            // pbxUsuario2
            // 
            this.pbxUsuario2.Image = global::Prueba_Control.Properties.Resources.Usuario2;
            this.pbxUsuario2.Location = new System.Drawing.Point(188, 121);
            this.pbxUsuario2.Name = "pbxUsuario2";
            this.pbxUsuario2.Size = new System.Drawing.Size(150, 150);
            this.pbxUsuario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUsuario2.TabIndex = 4;
            this.pbxUsuario2.TabStop = false;
            this.pbxUsuario2.Click += new System.EventHandler(this.pbxUsuario2_Click);
            // 
            // pbxUsuario1
            // 
            this.pbxUsuario1.Image = global::Prueba_Control.Properties.Resources.Usuario1;
            this.pbxUsuario1.Location = new System.Drawing.Point(24, 121);
            this.pbxUsuario1.Name = "pbxUsuario1";
            this.pbxUsuario1.Size = new System.Drawing.Size(150, 150);
            this.pbxUsuario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUsuario1.TabIndex = 2;
            this.pbxUsuario1.TabStop = false;
            this.pbxUsuario1.Click += new System.EventHandler(this.pbxUsuario1_Click);
            // 
            // lblValidar
            // 
            this.lblValidar.AutoSize = true;
            this.lblValidar.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblValidar.Location = new System.Drawing.Point(382, 255);
            this.lblValidar.Name = "lblValidar";
            this.lblValidar.Size = new System.Drawing.Size(0, 0);
            this.lblValidar.TabIndex = 10;
            // 
            // epErrores
            // 
            this.epErrores.ContainerControl = this;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 333);
            this.Controls.Add(this.lblValidar);
            this.Controls.Add(this.lblIndicacion2);
            this.Controls.Add(this.lblIndicacion1);
            this.Controls.Add(this.txtcContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUsuario2);
            this.Controls.Add(this.lblUsuario1);
            this.Controls.Add(this.pbxUsuario2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pbxUsuario1);
            this.Controls.Add(this.lblIniciosRecientes);
            this.Name = "PaginaPrincipal";
            this.Text = "Página Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblIniciosRecientes;
        private System.Windows.Forms.PictureBox pbxUsuario1;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private System.Windows.Forms.PictureBox pbxUsuario2;
        private MetroFramework.Controls.MetroLabel lblUsuario1;
        private MetroFramework.Controls.MetroLabel lblUsuario2;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel lblContrasenia;
        private Control.TextBoxContrasenia txtcContrasenia;
        private MetroFramework.Controls.MetroLabel lblIndicacion1;
        private MetroFramework.Controls.MetroLabel lblIndicacion2;
        private MetroFramework.Controls.MetroLabel lblValidar;
        private System.Windows.Forms.ErrorProvider epErrores;
    }
}