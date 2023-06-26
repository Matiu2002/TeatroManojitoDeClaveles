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
    public partial class Registro_Colab : Form
    {
        public Registro_Colab()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Los tente")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Los tente";
                txtNombre.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtFianzan_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "1234567")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtFianzan_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "1234567";
                txtNombre.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtFianzaP_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "0.18")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtFianzaP_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "0.18";
                txtNombre.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
