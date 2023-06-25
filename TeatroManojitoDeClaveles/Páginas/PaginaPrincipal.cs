using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatroManojitoDeClaveles.Páginas
{
    public partial class PaginaPrincipal : UserControl
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRes.Visible = true;*/
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Normal;
            btnRes.Visible = false;
            btnMax.Visible = true;*/
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //AbrirForm(new Form2());
        }
        /*[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]*/
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirForm(object form)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            //AbrirForm(new Funciones());
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            //AbrirForm(new Suscripcion());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //AbrirForm(new RegistroFuncion());
        }
    }
}
