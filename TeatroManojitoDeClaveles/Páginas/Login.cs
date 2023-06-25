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

namespace TeatroManojitoDeClaveles.Páginas
{
    public partial class Login : UserControl
    {
        private string rut, contraseña;
        private ConexionBD cbd;
        public Login()
        {
            InitializeComponent();
        }

        private bool IniciarSesion()
        {
            bool ok = true;
            if (ObtenerDatos())
            {

            }
            return true;
        }
        private bool ObtenerDatos()
        {
            bool ok = true;
            //Obtener datos


            //Comprobar datos
            Rut r = new Rut(rut);

            return true;
        }
    }
}
