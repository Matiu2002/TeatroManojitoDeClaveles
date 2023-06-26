namespace TeatroManojitoDeClaveles
{
    partial class InfoTicket
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblValido = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CodigoTicket";
            // 
            // txtRut
            // 
            this.txtRut.BackColor = System.Drawing.Color.Gray;
            this.txtRut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRut.ForeColor = System.Drawing.Color.White;
            this.txtRut.Location = new System.Drawing.Point(249, 123);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(146, 23);
            this.txtRut.TabIndex = 16;
            this.txtRut.Text = "1234";
            // 
            // btnValidar
            // 
            this.btnValidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidar.Location = new System.Drawing.Point(255, 382);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(140, 58);
            this.btnValidar.TabIndex = 27;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // lblValido
            // 
            this.lblValido.AutoSize = true;
            this.lblValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValido.ForeColor = System.Drawing.Color.White;
            this.lblValido.Location = new System.Drawing.Point(251, 183);
            this.lblValido.Name = "lblValido";
            this.lblValido.Size = new System.Drawing.Size(14, 20);
            this.lblValido.TabIndex = 28;
            this.lblValido.Text = "-";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFuncion.ForeColor = System.Drawing.Color.White;
            this.lblFuncion.Location = new System.Drawing.Point(251, 231);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(14, 20);
            this.lblFuncion.TabIndex = 30;
            this.lblFuncion.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(251, 279);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(14, 20);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "-";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(251, 322);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(14, 20);
            this.lblHora.TabIndex = 32;
            this.lblHora.Text = "-";
            // 
            // InfoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 467);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.lblValido);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoTicket";
            this.Text = "InfoTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblValido;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
    }
}