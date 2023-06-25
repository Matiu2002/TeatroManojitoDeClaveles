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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_Enter(object sender, EventArgs e)
        {
            if (txtRut.Text == "Romeo y Julieta")
            {
                txtRut.Text = "";
                txtRut.ForeColor = Color.White;
            }
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (txtRut.Text == "")
            {
                txtRut.Text = "Romeo y Julieta";
                txtRut.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtProta_Enter(object sender, EventArgs e)
        {
            if (txtProta.Text == " Hugh Jackman")
            {
                txtProta.Text = "";
                txtProta.ForeColor = Color.White;
            }
        }

        private void txtProta_Leave(object sender, EventArgs e)
        {
            if (txtProta.Text == "")
            {
                txtProta.Text = " Hugh Jackman";
                txtProta.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtEstreno_Enter(object sender, EventArgs e)
        {
            if (txtEstreno.Text == "1 de enero 2023")
            {
                txtEstreno.Text = "";
                txtEstreno.ForeColor = Color.White;
            }

        }

        private void txtEstreno_Leave(object sender, EventArgs e)
        {
            if (txtEstreno.Text == "")
            {
                txtEstreno.Text = "1 de enero 2023";
                txtEstreno.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtDuracion_Enter(object sender, EventArgs e)
        {
            if (txtDuracion.Text == "15:30")
            {
                txtDuracion.Text = "";
                txtDuracion.ForeColor = Color.White;
            }
        }

        private void txtDuracion_Leave(object sender, EventArgs e)
        {
            if (txtDuracion.Text == "")
            {
                txtDuracion.Text = "15:30";
                txtDuracion.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtSinopsis_Enter(object sender, EventArgs e)
        {
            if (txtSinopsis.Text == "Esta obra va a tratar de.......")
            {
                txtSinopsis.Text = "";
                txtSinopsis.ForeColor = Color.White;
            }
        }

        private void txtSinopsis_Leave(object sender, EventArgs e)
        {
            if (txtSinopsis.Text == "")
            {
                txtSinopsis.Text = "Esta obra va a tratar de.......";
                txtSinopsis.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
