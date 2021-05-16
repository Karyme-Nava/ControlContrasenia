
namespace Prueba_Control
{
    partial class AccesoCuenta
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
            this.txtcContrasenia = new Control.TextBoxContrasenia();
            this.lblIndicacion = new MetroFramework.Controls.MetroLabel();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.cbxUsuarios = new MetroFramework.Controls.MetroComboBox();
            this.epErrores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcContrasenia
            // 
            this.txtcContrasenia.BackColor = System.Drawing.Color.White;
            this.txtcContrasenia.Contrasenia = "";
            this.txtcContrasenia.Location = new System.Drawing.Point(58, 287);
            this.txtcContrasenia.MaximumSize = new System.Drawing.Size(300, 38);
            this.txtcContrasenia.MinimumSize = new System.Drawing.Size(179, 38);
            this.txtcContrasenia.Name = "txtcContrasenia";
            this.txtcContrasenia.Size = new System.Drawing.Size(179, 38);
            this.txtcContrasenia.TabIndex = 1;
            this.txtcContrasenia.VisibilidadBotonIngresar = true;
            this.txtcContrasenia.ContraseniaIngresada += new System.EventHandler(this.txtcContrasenia_ContraseniaIngresada);
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblIndicacion.Location = new System.Drawing.Point(16, 60);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(260, 15);
            this.lblIndicacion.TabIndex = 2;
            this.lblIndicacion.Text = "Para continuar, primero debes verificar tu identidad";
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Location = new System.Drawing.Point(71, 92);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(150, 150);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUsuario.TabIndex = 1;
            this.pbxUsuario.TabStop = false;
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.FormattingEnabled = true;
            this.cbxUsuarios.ItemHeight = 23;
            this.cbxUsuarios.Location = new System.Drawing.Point(85, 249);
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Size = new System.Drawing.Size(121, 29);
            this.cbxUsuarios.TabIndex = 0;
            this.cbxUsuarios.UseSelectable = true;
            this.cbxUsuarios.SelectedValueChanged += new System.EventHandler(this.cbxUsuarios_SelectedValueChanged);
            // 
            // epErrores
            // 
            this.epErrores.ContainerControl = this;
            // 
            // AccesoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 335);
            this.Controls.Add(this.cbxUsuarios);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.txtcContrasenia);
            this.Controls.Add(this.pbxUsuario);
            this.Name = "AccesoCuenta";
            this.Text = "Acceso a cuenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccesoCuenta_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxUsuario;
        private Control.TextBoxContrasenia txtcContrasenia;
        private MetroFramework.Controls.MetroLabel lblIndicacion;
        private MetroFramework.Controls.MetroComboBox cbxUsuarios;
        private System.Windows.Forms.ErrorProvider epErrores;
    }
}