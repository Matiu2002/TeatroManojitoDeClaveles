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
    public partial class Estadisticas : Form
    {
        Dictionary<int, string> lista;
        public Estadisticas()
        {
            InitializeComponent();
            Inicializar();
        }
        public void Inicializar()
        {
            ConexionBD bd = new ConexionBD();
            DataSet ds = bd.ConsultasSQL("select * from NOMBRE_ACTIVIDAD");
            lista = new Dictionary<int, string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lista.Add(int.Parse(ds.Tables[0].Rows[i]["id"].ToString()), ds.Tables[0].Rows[i]["nom"].ToString());
            }
            comboBox1.DataSource = lista.Values.ToList();
            DataSet ds1 = bd.ConsultasSQL("select * from REGISTRO_HISTORICO where idNombreAct = 1");
            lblAsis.Text = ds1.Tables[0].Rows[0]["promAsistencia"].ToString();
            label3.Text = ds1.Tables[0].Rows[0]["cantPersonal"].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionBD bd = new ConexionBD();
            ComboBox c = (ComboBox)sender;
            int i = c.SelectedIndex + 1;
            DataSet ds1 = bd.ConsultasSQL("select * from REGISTRO_HISTORICO where idNombreAct = " + i);
            lblAsis.Text = ds1.Tables[0].Rows[0]["promAsistencia"].ToString();
            label3.Text = ds1.Tables[0].Rows[0]["cantPersonal"].ToString();
        }
    }
}
