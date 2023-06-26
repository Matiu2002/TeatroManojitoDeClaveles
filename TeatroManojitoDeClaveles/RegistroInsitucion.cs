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
    public partial class RegistroInsitucion : Form
    {
        public RegistroInsitucion()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "El pepe")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "El pepe";
                txtNombre.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "420")
            {
                txtCantidad.Text = "";
                txtCantidad.ForeColor = Color.White;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "420";
                txtCantidad.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
