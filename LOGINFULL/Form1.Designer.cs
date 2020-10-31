namespace LOGINFULL
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.ETI_USUARIO = new System.Windows.Forms.Label();
            this.ETI_PASSWORD = new System.Windows.Forms.Label();
            this.BT_INGRESAR = new System.Windows.Forms.Button();
            this.BT_SALIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(124, 25);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(215, 26);
            this.txtusuario.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(124, 92);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(215, 26);
            this.txtpassword.TabIndex = 1;
            // 
            // ETI_USUARIO
            // 
            this.ETI_USUARIO.AutoSize = true;
            this.ETI_USUARIO.Location = new System.Drawing.Point(34, 25);
            this.ETI_USUARIO.Name = "ETI_USUARIO";
            this.ETI_USUARIO.Size = new System.Drawing.Size(84, 20);
            this.ETI_USUARIO.TabIndex = 2;
            this.ETI_USUARIO.Text = "USUARIO";
            this.ETI_USUARIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // ETI_PASSWORD
            // 
            this.ETI_PASSWORD.AutoSize = true;
            this.ETI_PASSWORD.Location = new System.Drawing.Point(-1, 92);
            this.ETI_PASSWORD.Name = "ETI_PASSWORD";
            this.ETI_PASSWORD.Size = new System.Drawing.Size(119, 20);
            this.ETI_PASSWORD.TabIndex = 3;
            this.ETI_PASSWORD.Text = "CONTRASEÑA";
            this.ETI_PASSWORD.Click += new System.EventHandler(this.label2_Click);
            // 
            // BT_INGRESAR
            // 
            this.BT_INGRESAR.Location = new System.Drawing.Point(109, 186);
            this.BT_INGRESAR.Name = "BT_INGRESAR";
            this.BT_INGRESAR.Size = new System.Drawing.Size(107, 42);
            this.BT_INGRESAR.TabIndex = 4;
            this.BT_INGRESAR.Text = "INGRESAR";
            this.BT_INGRESAR.UseVisualStyleBackColor = true;
            this.BT_INGRESAR.Click += new System.EventHandler(this.BT_INGRESAR_Click);
            // 
            // BT_SALIR
            // 
            this.BT_SALIR.Location = new System.Drawing.Point(429, 187);
            this.BT_SALIR.Name = "BT_SALIR";
            this.BT_SALIR.Size = new System.Drawing.Size(112, 41);
            this.BT_SALIR.TabIndex = 5;
            this.BT_SALIR.Text = "SALIR";
            this.BT_SALIR.UseVisualStyleBackColor = true;
            this.BT_SALIR.Click += new System.EventHandler(this.BT_SALIR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGINFULL.Properties.Resources.cyber_mikyuli_2020;
            this.pictureBox1.Location = new System.Drawing.Point(354, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(655, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BT_SALIR);
            this.Controls.Add(this.BT_INGRESAR);
            this.Controls.Add(this.ETI_PASSWORD);
            this.Controls.Add(this.ETI_USUARIO);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label ETI_USUARIO;
        private System.Windows.Forms.Label ETI_PASSWORD;
        private System.Windows.Forms.Button BT_INGRESAR;
        private System.Windows.Forms.Button BT_SALIR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

