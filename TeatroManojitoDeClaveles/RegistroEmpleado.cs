using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatroManojitoDeClaveles
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void txtRut_Enter(object sender, EventArgs e)
        {
            if (txtRut.Text == "11.111.111-1")
            {
                txtRut.Text = "";
                txtRut.ForeColor = Color.White;
            }
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (txtRut.Text == "")
            {
                txtRut.Text = "11.111.111-1";
                txtRut.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Diego")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Diego";
                txtNombre.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Canales")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.White;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Canales";
                txtApellido.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "diegocanales@gmail.com")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "diegocanales@gmail.com";
                txtCorreo.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "912345678")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "912345678";
                textBox1.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
