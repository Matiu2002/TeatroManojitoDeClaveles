using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroManojitoDeClaveles.Clases;
using WPFPublicidad.Clases;

namespace TeatroManojitoDeClaveles
{
    public partial class Suscrito : Form
    {
        private Cliente c;
        public Suscrito()
        {
            InitializeComponent();
            Inicializar();
        }
        private void Inicializar()
        {
            c = new Cliente(((Form1)((Panel)Parent).Parent).cliente);
            if(c.Membresia == "No")
            {
                lblSuscrito.Text = "No suscrito";
            }
            else
            {
                lblSuscrito.Text = c.Membresia;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(chkSi.Checked && lblSuscrito.Text == "No suscrito")
            {
                if(MessageBox.Show("¿Estás seguro?", "Suscripción Amigo del teatro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConexionBD bd = new ConexionBD();
                    if (bd.EscribirDatosSQL(""))
                    {
                        MessageBox.Show("Te has suscrito con éxito.");
                    }
                }
            }
            else if(lblSuscrito.Text != "No suscrito")
            {
                MessageBox.Show("Ya estás suscrito.");
            }
        }
    }
}
