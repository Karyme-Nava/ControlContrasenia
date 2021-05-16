
namespace Control
{
    partial class TextBoxContrasenia
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblMayusculas = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pbxVisibilidad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasenia.Location = new System.Drawing.Point(1, 1);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(138, 20);
            this.txtContrasenia.TabIndex = 0;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            this.txtContrasenia.Enter += new System.EventHandler(this.txtContrasenia_Enter);
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasenia_KeyDown);
            // 
            // lblMayusculas
            // 
            this.lblMayusculas.AutoSize = true;
            this.lblMayusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayusculas.Location = new System.Drawing.Point(5, 24);
            this.lblMayusculas.Name = "lblMayusculas";
            this.lblMayusculas.Size = new System.Drawing.Size(0, 12);
            this.lblMayusculas.TabIndex = 2;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackgroundImage = global::Control.Properties.Resources.Flecha;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(156, 0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(22, 22);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pbxVisibilidad
            // 
            this.pbxVisibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxVisibilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxVisibilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxVisibilidad.Image = global::Control.Properties.Resources.Ojo_visible;
            this.pbxVisibilidad.Location = new System.Drawing.Point(136, 1);
            this.pbxVisibilidad.Name = "pbxVisibilidad";
            this.pbxVisibilidad.Size = new System.Drawing.Size(20, 20);
            this.pbxVisibilidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVisibilidad.TabIndex = 1;
            this.pbxVisibilidad.TabStop = false;
            this.pbxVisibilidad.Click += new System.EventHandler(this.pbxVisibilidad_Click);
            // 
            // TextBoxContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblMayusculas);
            this.Controls.Add(this.pbxVisibilidad);
            this.Controls.Add(this.txtContrasenia);
            this.MaximumSize = new System.Drawing.Size(300, 38);
            this.MinimumSize = new System.Drawing.Size(179, 38);
            this.Name = "TextBoxContrasenia";
            this.Size = new System.Drawing.Size(179, 38);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVisibilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.PictureBox pbxVisibilidad;
        private System.Windows.Forms.Label lblMayusculas;
        private System.Windows.Forms.Button btnIngresar;
    }
}
