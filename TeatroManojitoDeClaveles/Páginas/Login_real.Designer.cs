namespace TeatroManojitoDeClaveles.Páginas
{
    partial class Login_real
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
            this.btAcceder = new System.Windows.Forms.Button();
            this.lklblContrasenia = new System.Windows.Forms.LinkLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btAcceder
            // 
            this.btAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btAcceder.FlatAppearance.BorderSize = 0;
            this.btAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btAcceder.Location = new System.Drawing.Point(151, 271);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(382, 66);
            this.btAcceder.TabIndex = 8;
            this.btAcceder.Text = "ACCEDER";
            this.btAcceder.UseVisualStyleBackColor = false;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // lklblContrasenia
            // 
            this.lklblContrasenia.AutoSize = true;
            this.lklblContrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblContrasenia.LinkColor = System.Drawing.Color.DimGray;
            this.lklblContrasenia.Location = new System.Drawing.Point(225, 358);
            this.lklblContrasenia.Name = "lklblContrasenia";
            this.lklblContrasenia.Size = new System.Drawing.Size(237, 21);
            this.lklblContrasenia.TabIndex = 9;
            this.lklblContrasenia.TabStop = true;
            this.lklblContrasenia.Text = "¿Ha olvidado su contrasena?";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(208, 75);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(270, 23);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(198, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "CONTRASEÑA";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnRegistro
            // 
            this.btnRegistro.AutoSize = true;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.LinkColor = System.Drawing.Color.DimGray;
            this.btnRegistro.Location = new System.Drawing.Point(178, 404);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(320, 21);
            this.btnRegistro.TabIndex = 12;
            this.btnRegistro.TabStop = true;
            this.btnRegistro.Text = "¿No tienes una cuenta? Registrate aquí";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(676, 467);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lklblContrasenia);
            this.Controls.Add(this.btAcceder);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            //this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAcceder;
        private System.Windows.Forms.LinkLabel lklblContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel btnRegistro;
    }
}
