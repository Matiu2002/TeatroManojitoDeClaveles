using Microsoft.IdentityModel.Tokens;
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
using System.Text.RegularExpressions;

namespace TeatroManojitoDeClaveles.Páginas
{
    public partial class Login : UserControl
    {
        private string user, contraseña, tipo;
        public Login()
        {
            InitializeComponent();
        }

        private bool IniciarSesion()
        {
            if (ObtenerDatos())
            {
                return ConsultaBD();
            }
            return false;
        }
        private bool ObtenerDatos()
        {
            //Obtener datos


            //Comprobar datos
            Rut r = new Rut(user);
            if(r.ToString() == "0-0")
            {
                //Verificar si es un correo
                Regex cor = new Regex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
                if (cor.IsMatch(user))
                {
                    tipo = "usuario";
                }
                else
                {
                    return false;
                }
            }
            else
            {
                tipo = "admin";
            }
            if (!contraseña.IsNullOrEmpty())
            {
                //Verificar si la contraseña es valida
                //Debe tener entre 8 y 16 caracteres, minimo 1 mayuscula, 1 minuscula y 1 digito
                Regex con = new Regex(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$");
                return con.IsMatch(contraseña);
            }
            return false;
        }
        private bool ConsultaBD()
        {
            ConexionBD con = new ConexionBD();
            if (tipo == "usuario")
            {
                DataSet ds = con.ConsultasSQL(@"select correo, nombre, contraseña from CLIENTE");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    if (ds.Tables[0].Rows[0]["contraseña"].Equals(contraseña))
                    {
                        return true;
                        //nombre = ds.Tables[0].Rows[0]["USU_Nombre"].ToString(); OPCIONAL
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe, compruebe los datos ingresados.");
                }
            }
            else
            {
                DataSet ds = con.ConsultasSQL(@"select rut, nombre, contraseña from EMPLEADO");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    if (ds.Tables[0].Rows[0]["contraseña"].Equals(contraseña))
                    {
                        return true;
                        //nombre = ds.Tables[0].Rows[0]["USU_Nombre"].ToString(); OPCIONAL
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe, compruebe los datos ingresados.");
                }
            }
            return false;
        }
    }
}
