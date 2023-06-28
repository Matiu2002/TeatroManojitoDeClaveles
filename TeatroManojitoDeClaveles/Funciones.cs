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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.IdentityModel.Tokens;

namespace TeatroManojitoDeClaveles
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
            Cargar();
        }

       
        private void Cargar()
        {
            ConexionBD c = new ConexionBD();
            string cadena = "select nomEvento,costo,fecha,hora from ACTIVIDAD";
            dataGridView1.DataSource = c.ConsultasSQL(cadena).Tables[0];
        }

        private void Funciones_Load(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se compro su ticket para la funcion: "+lblNombre.Text+" con un valor de: "+lblCosto.Text+" el dia: "+lblFuncion.Text+" a la hora: "+lblHora.Text);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.lblCosto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.lblFuncion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.lblHora.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            ConexionBD c = new ConexionBD();
            if (textBox1.Text.IsNullOrEmpty())
            {
                string cadena = "select nomEvento,costo,fecha,hora from ACTIVIDAD";
                dataGridView1.DataSource = c.ConsultasSQL(cadena).Tables[0];
            }
            else
            {
                string cadena = "select nomEvento,costo,fecha,hora from ACTIVIDAD where nomEvento= '" + textBox1.Text + "'";
                dataGridView1.DataSource = c.ConsultasSQL(cadena).Tables[0];
            }
        }
    }
}
