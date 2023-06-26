namespace TeatroManojitoDeClaveles
{
    partial class Registro_Colab
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFianzan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFianzaP = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(108, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(471, 39);
            this.label7.TabIndex = 29;
            this.label7.Text = "REGISTRO COLABORADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre:*";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Gray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(115, 172);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 23);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.Text = "Los tente";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Finanza:*";
            // 
            // txtFianzan
            // 
            this.txtFianzan.BackColor = System.Drawing.Color.Gray;
            this.txtFianzan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFianzan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFianzan.ForeColor = System.Drawing.Color.White;
            this.txtFianzan.Location = new System.Drawing.Point(373, 172);
            this.txtFianzan.Name = "txtFianzan";
            this.txtFianzan.Size = new System.Drawing.Size(146, 23);
            this.txtFianzan.TabIndex = 34;
            this.txtFianzan.Text = "1234567";
            this.txtFianzan.Enter += new System.EventHandler(this.txtFianzan_Enter);
            this.txtFianzan.Leave += new System.EventHandler(this.txtFianzan_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Finanza Porcentual:*";
            // 
            // txtFianzaP
            // 
            this.txtFianzaP.BackColor = System.Drawing.Color.Gray;
            this.txtFianzaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFianzaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFianzaP.ForeColor = System.Drawing.Color.White;
            this.txtFianzaP.Location = new System.Drawing.Point(115, 295);
            this.txtFianzaP.Name = "txtFianzaP";
            this.txtFianzaP.Size = new System.Drawing.Size(146, 23);
            this.txtFianzaP.TabIndex = 36;
            this.txtFianzaP.Text = "0.18";
            this.txtFianzaP.Enter += new System.EventHandler(this.txtFianzaP_Enter);
            this.txtFianzaP.Leave += new System.EventHandler(this.txtFianzaP_Leave);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistro.Location = new System.Drawing.Point(493, 358);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(140, 58);
            this.btnRegistro.TabIndex = 37;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // Registro_Colab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(660, 428);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtFianzaP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFianzan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Colab";
            this.Text = "Registro_Colab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFianzan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFianzaP;
        private System.Windows.Forms.Button btnRegistro;
    }
}