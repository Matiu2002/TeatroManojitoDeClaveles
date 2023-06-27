namespace TeatroManojitoDeClaveles
{
    partial class Suscrito
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
            this.lblSuscrito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSi = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(122, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 39);
            this.label7.TabIndex = 28;
            this.label7.Text = "SUSCRITOS";
            // 
            // lblSuscrito
            // 
            this.lblSuscrito.AutoSize = true;
            this.lblSuscrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSuscrito.ForeColor = System.Drawing.Color.White;
            this.lblSuscrito.Location = new System.Drawing.Point(158, 109);
            this.lblSuscrito.Name = "lblSuscrito";
            this.lblSuscrito.Size = new System.Drawing.Size(14, 20);
            this.lblSuscrito.TabIndex = 29;
            this.lblSuscrito.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Desea Suscribirse";
            // 
            // chkSi
            // 
            this.chkSi.AutoSize = true;
            this.chkSi.Location = new System.Drawing.Point(198, 245);
            this.chkSi.Name = "chkSi";
            this.chkSi.Size = new System.Drawing.Size(35, 17);
            this.chkSi.TabIndex = 32;
            this.chkSi.Text = "Si";
            this.chkSi.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(495, 386);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 58);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(445, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tiempo Suscrito";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(445, 156);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(14, 20);
            this.lblTiempo.TabIndex = 35;
            this.lblTiempo.Text = "-";
            // 
            // Suscrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 467);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.chkSi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuscrito);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suscrito";
            this.Text = "Suscrito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSuscrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSi;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTiempo;
    }
}