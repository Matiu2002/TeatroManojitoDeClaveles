using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatroManojitoDeClaveles.Clases
{
    public class Teatro
    {
        private string nombre;
        private string direccion;
        private int utilidades;
        private List<Pared> paredes;
        private List<Colaborador> colaboradores;
        private List<Actividad> actividades;
        private List<Cliente> clientes;
        private List<Ticket> tickets;
        private List<Empleado> empleados;

        public Teatro()
        {
            nombre = "Sin definir";
            direccion = "Sin definir";
            utilidades = 0;
            paredes = new List<Pared>();
            colaboradores = new List<Colaborador>();
            actividades = new List<Actividad>();
            clientes = new List<Cliente>();
            tickets = new List<Ticket>();
            empleados = new List<Empleado>();
        }
        public Teatro(string n, string d, int u, bool aoc)
        {
            nombre = n;
            direccion = d;
            utilidades = u;
            paredes = new List<Pared>();
            colaboradores = new List<Colaborador>();
            actividades = new List<Actividad>();
            clientes = new List<Cliente>();
            tickets = new List<Ticket>();
            empleados = new List<Empleado>();
        }
        public Teatro(string t)
        {
            string[] campo = t.Split(',');
            nombre = campo[0];
            direccion = campo[1];
            int.TryParse(campo[2], out utilidades);
            paredes = new List<Pared>();
            colaboradores = new List<Colaborador>();
            actividades = new List<Actividad>();
            clientes = new List<Cliente>();
            tickets = new List<Ticket>();
            empleados = new List<Empleado>();
        }
        public Teatro(Teatro t)
        {
            nombre = t.nombre;
            direccion = t.direccion;
            utilidades = t.utilidades;
            paredes = t.paredes;
            colaboradores = t.colaboradores;
            actividades = t.actividades;
            clientes = t.clientes;
            tickets = t.tickets;
            empleados = t.empleados;
        }
        public Teatro(string nombre, string direccion, DataSet ds)
        {
            this.nombre = nombre;
            this.direccion = direccion;

            LlenarActividades(ds);
        }
        public void LlenarActividades(DataSet ds)
        {
            actividades = new List<Actividad>();
            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["id"].ToString();
                    string nombre = ds.Tables[0].Rows[i]["nomEvento"].ToString();
                    string costo = ds.Tables[0].Rows[i]["costo"].ToString();
                    string fecha = ds.Tables[0].Rows[i]["fecha"].ToString();
                    string hora = ds.Tables[0].Rows[i]["hora"].ToString();
                    string razon = ds.Tables[0].Rows[i]["razonCausa"].ToString();
                    string capacidad = ds.Tables[0].Rows[i]["capacidad"].ToString();
                    string tipo = ds.Tables[0].Rows[i]["nom"].ToString();

                    if (capacidad.IsNullOrEmpty())
                    {
                        actividades.Add(new Actividad(int.Parse(id), fecha, hora, nombre, tipo, int.Parse(costo)));
                    }
                    else if (razon.IsNullOrEmpty())
                    {
                        actividades.Add(new Evento(int.Parse(id), fecha, hora, nombre, tipo, int.Parse(costo), int.Parse(capacidad), 6));
                    }
                    else
                    {
                        actividades.Add(new Evento_FB(int.Parse(id), fecha, hora, nombre, tipo, int.Parse(costo), int.Parse(capacidad), 6, razon));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
