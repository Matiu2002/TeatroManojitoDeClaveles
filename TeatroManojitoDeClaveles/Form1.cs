using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TeatroManojitoDeClaveles.Clases;
using WPFPublicidad.Clases;

namespace TeatroManojitoDeClaveles
{
    public partial class Form1 : Form
    {
        public Teatro teatro;
        public Cliente cliente;
        public Form1()
        {
            InitializeComponent();
            LlenarInicial();
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRes.Visible = true;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRes.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirForm(object form)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);
            Form fh=form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            AbrirForm(new Funciones());
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            AbrirForm(new Suscrito());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroFuncion());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroEmpleado());
        }

        private void txtColab_Click(object sender, EventArgs e)
        {
            AbrirForm(new Registro_Colab());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new Estadisticas());
        }

        private void btnInstitucion_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroInsitucion());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.AutoScroll = true;
        }
        private bool LlenarInicial()
        {
            ConexionBD bd = new ConexionBD();
            DataSet ds = bd.ConsultasSQL("SELECT A.id, A.nomEvento, A.costo, A.hora, A.fecha, A.capacidad, AB.razonCausa, NA.nom FROM ACTIVIDAD as A left join ACTIVIDAD_BENEFICA as AB on A.idActBenefica = AB.id left join NOMBRE_ACTIVIDAD as NA on A.idNombreAct = NA.id\r\n");
            teatro = new Teatro("Manojito de claveles", "lala12345", ds);
            teatro.LlenarArtistasFunciones();
            teatro.LlenarValoresEventos();
            return true;
        }
        public bool LlenarAdmin()
        {
            teatro.LlenarParedes();
            teatro.LlenarClientes();
            teatro.LlenarTickets();
            teatro.LlenarEmpleados();
            teatro.LlenarColaboradores();
            return true;
        }
        public bool LlenarCliente(Cliente c)
        {
            cliente = new Cliente(c);
            return true;
        }
    }
}
