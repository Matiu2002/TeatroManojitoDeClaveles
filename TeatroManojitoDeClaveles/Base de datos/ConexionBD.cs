using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace WPFPublicidad.Clases
{
    internal class ConexionBD
    {
        private string CadenaConexion;
        private SqlConnection Conexion;

        public ConexionBD()
        {
            // Hay que corregir el nombre
            CadenaConexion = @"Data Source=DESKTOP-BUL9PBP\SQLEXPRESS; Initial Catalog= manojitodeclavelesceleste2; Integrated Security=true; TrustServerCertificate=True";
            Conexion = new SqlConnection(CadenaConexion);
        }
        public DataSet ConsultasSQL(string ConsSQL)
        {
            DataSet ds = new DataSet();
            try
            {
                Conexion.Open();
                SqlCommand c = new SqlCommand(ConsSQL, Conexion);
                SqlDataAdapter sqlDA = new SqlDataAdapter(c);
                sqlDA.Fill(ds);
                Conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return ds;
        }
        public bool EscribirDatosSQL(string ConsSQL)
        {
            bool ok = false;
            try
            {
                Conexion.Open();
                SqlCommand c = new SqlCommand(ConsSQL, Conexion);
                c.ExecuteNonQuery();
                Conexion.Close();
                ok = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return ok;
        }

        public void Open()
        {
            try
            {
                Conexion.Open();
                Console.WriteLine("DB working");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening db: " + ex.Message);
            }
        }

        public void Close()
        {
            Conexion.Close();
        }
        /*
        public string Login(string rut, string clave)
        {
            string tipo = "Sin asignar";
            string nombre = "";
            DataSet ds = ConsultasSQL(@"select u.USU_Id, u.USU_Nombre, u.USU_Clave, tu.TIP_Nombre from USUARIO u inner join TIPO_USUARIO tu on u.TIP_Id = tu.TIP_Id where u.USU_Id = '" + rut + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (ds.Tables[0].Rows[0]["USU_Clave"].Equals(clave))
                {
                    tipo = ds.Tables[0].Rows[0]["TIP_Nombre"].ToString();
                    nombre = ds.Tables[0].Rows[0]["USU_Nombre"].ToString();
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
            return tipo + ";" + nombre;
        }
        public bool RegistrarTrabajador(string datos)
        {
            bool ok = false;
            try
            {
                Conexion.Open();
                string[] campo = datos.Split(';');
                string consulta = "insert into Usuario(USU_Id, USU_Nombre, USU_Correo, USU_Clave, TIP_Id) values (" + campo[0] + ", '" + campo[1] + "', '" + campo[2] + "', '" + campo[3] + "', 2);";
                SqlCommand c = new SqlCommand(consulta, Conexion);
                c.ExecuteNonQuery();
                ok = true;
                Conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return ok;
        }
        public bool RegistrarCliente(string datosusuario, string datoscliente, string datosempresa, string datoscontrato)
        {
            bool ok = false;
            try
            {
                Conexion.Open();
                string[] campo = datosusuario.Split(';');
                string consulta = "insert into Usuario(USU_Id, USU_Nombre, USU_Correo, USU_Clave, TIP_Id) values (" + campo[0] + ", '" + campo[1] + "', '" + campo[2] + "', '" + "" + "', 3);";
                SqlCommand c = new SqlCommand(consulta, Conexion);
                c.ExecuteNonQuery();
                ok = true;
                Conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return ok;
        }
        */
    }
}
