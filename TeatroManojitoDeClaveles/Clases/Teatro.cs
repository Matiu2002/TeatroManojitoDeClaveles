using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPFPublicidad.Clases;

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
        public List<Actividad> Actividades
        {
            get { return actividades; }
            set { actividades = value; }
        }

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
        public void LlenarArtistasFunciones()
        {
            ConexionBD db = new ConexionBD();
            foreach (Actividad a in actividades)
            {
                DataSet ds = db.ConsultasSQL("SELECT DAA.idArtista, I.id, A.nombre as nom, I.nombre, I.personaje, ACT.nomEvento\r\nFROM DETALLE_ACTIVIDAD_ARTISTA DAA LEFT JOIN ARTISTA A ON DAA.idArtista = A.id\r\nLEFT JOIN INTEGRANTE I ON A.id = I.idArtista\r\nLEFT JOIN ACTIVIDAD ACT ON DAA.idTipoActividad = ACT.id\r\nWHERE ACT.id =" + a.ID);
                string nombre = ds.Tables[0].Rows[0]["nom"].ToString();
                int idev = int.Parse(ds.Tables[0].Rows[0]["idArtista"].ToString());
                if (a is Evento)
                {
                    Evento e = (Evento)a;
                    e.Artistas = new List<Artista>();
                    if (ds.Tables[0].Rows[0]["nombre"].ToString().IsNullOrEmpty())
                    {

                        Artista ar = new Artista(idev, nombre);
                        e.Artistas.Add(ar);
                    }
                    else if (ds.Tables[0].Rows[0]["personaje"].ToString().IsNullOrEmpty())
                    {
                        Grupo g = new Grupo(idev, nombre);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            int id = int.Parse(ds.Tables[0].Rows[i]["id"].ToString());
                            string nom = ds.Tables[0].Rows[i]["nombre"].ToString();
                            Integrante inte = new Integrante(id, nom);
                            g.Integrantes.Add(inte);
                        }
                        e.Artistas.Add(g);
                    }

                    else
                    {
                        Reparto g = new Reparto(idev, nombre);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            int id = int.Parse(ds.Tables[0].Rows[i]["id"].ToString());
                            string nom = ds.Tables[0].Rows[i]["nombre"].ToString();
                            string personaje = ds.Tables[0].Rows[i]["personaje"].ToString();
                            Actor inte = new Actor(id, nombre, personaje);
                            g.Actores.Add(inte);
                        }
                        e.Artistas.Add(g);
                    }
                }
            }
        }
        public void LlenarValoresEventos()
        {
            ConexionBD db = new ConexionBD();
            foreach (Actividad a in actividades)
            {
                DataSet ds = db.ConsultasSQL("SELECT * FROM valor_ticket WHERE idTipoActividad = " + a.ID);
                if (a is Evento)
                {
                    Evento e = (Evento)a;
                    e.Artistas = new List<Artista>();
                    int cantidadPA = int.Parse(ds.Tables[0].Rows[0]["cantidadPA"].ToString());
                    int cantidadPB = int.Parse(ds.Tables[0].Rows[0]["cantidadPB"].ToString());
                    int cantidadG = int.Parse(ds.Tables[0].Rows[0]["cantidadG"].ToString());
                    int cantidadB = int.Parse(ds.Tables[0].Rows[0]["cantidadB"].ToString());
                    int vendidoPA = int.Parse(ds.Tables[0].Rows[0]["vendidoPA"].ToString());
                    int vendidoPB = int.Parse(ds.Tables[0].Rows[0]["vendidoPB"].ToString());
                    int vendidoG = int.Parse(ds.Tables[0].Rows[0]["vendidoG"].ToString());
                    int vendidoB = int.Parse(ds.Tables[0].Rows[0]["vendidoB"].ToString());
                    int valorPlateaAlta = int.Parse(ds.Tables[0].Rows[0]["valorPlateaAlta"].ToString());
                    int valorPlateaBaja = int.Parse(ds.Tables[0].Rows[0]["valorPlateaBaja"].ToString());
                    int valorGaleria = int.Parse(ds.Tables[0].Rows[0]["valorGaleria"].ToString());
                    int valorBalcon = int.Parse(ds.Tables[0].Rows[0]["valorBalcon"].ToString());
                    e.Valores = new ValoresTickets(cantidadPA, valorPlateaAlta, vendidoPA, cantidadPB, valorPlateaBaja, vendidoPB, cantidadB, valorBalcon, vendidoB, cantidadG, valorGaleria, vendidoG);
                }
            }
        }
        public void LlenarParedes()
        {
            paredes = new List<Pared>();
            ConexionBD bd = new ConexionBD();
            DataSet ds = bd.ConsultasSQL("select * from pared");
            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["id"].ToString();
                    string nombre = ds.Tables[0].Rows[i]["nomEmpresa"].ToString();
                    string costo = ds.Tables[0].Rows[i]["costo"].ToString();
                    string fecha = ds.Tables[0].Rows[i]["fechaLimite"].ToString();

                    paredes.Add(new Pared(int.Parse(id), int.Parse(costo), fecha, nombre));
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void LlenarColaboradores()
        {
            colaboradores = new List<Colaborador>();
            ConexionBD bd = new ConexionBD();
            DataSet ds = bd.ConsultasSQL("select * from colaborador");
            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["id"].ToString();
                    string nombre = ds.Tables[0].Rows[i]["nom"].ToString();
                    string finan = ds.Tables[0].Rows[i]["finan"].ToString();
                    string finanPorc = ds.Tables[0].Rows[i]["finanPorcentual"].ToString();

                    colaboradores.Add(new Colaborador(int.Parse(id), nombre, float.Parse(finanPorc), int.Parse(finan)));
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void LlenarClientes()
        {
            clientes = new List<Cliente>();
            ConexionBD bd = new ConexionBD();
            DataSet ds = bd.ConsultasSQL("SELECT c.id, c.rut, c.correo, CONCAT(c.nombre, ' ', c.segNom, ' ', c.apellido, ' ', c.segApe) as nombreCompleto, s.id as idmem FROM CLIENTE as c left join SUSCRIPCION as s on c.id = s.idCliente\r\n");
            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["id"].ToString();
                    string idmem = ds.Tables[0].Rows[i]["idmem"].ToString();
                    string nombre = ds.Tables[0].Rows[i]["nombreCompleto"].ToString();
                    string rut = ds.Tables[0].Rows[i]["rut"].ToString();
                    string correo = ds.Tables[0].Rows[i]["correo"].ToString();
                    string suscripcion;
                    if (idmem.IsNullOrEmpty())
                    {
                        suscripcion = "No";
                    }
                    else
                    {
                        suscripcion = "Amigo del teatro";
                    }
                    clientes.Add(new Cliente(int.Parse(id), new Rut(rut), nombre, correo, suscripcion));
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void LlenarTickets()
        {
            //Revisar
            tickets = new List<Ticket>();
            ConexionBD bd = new ConexionBD();
            DataSet ds = bd.ConsultasSQL("select * from ticket");
            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["id"].ToString();
                    string nombre = ds.Tables[0].Rows[i]["nom"].ToString();
                    string finan = ds.Tables[0].Rows[i]["finan"].ToString();
                    string finanPorc = ds.Tables[0].Rows[i]["finanPorcentual"].ToString();

                    colaboradores.Add(new Colaborador(int.Parse(id), nombre, float.Parse(finanPorc), int.Parse(finan)));
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }//no listo
        public void LlenarEmpleados()
        {
            //Revisar
            ConexionBD db = new ConexionBD();
            foreach (Actividad a in actividades)
            {
                DataSet ds = db.ConsultasSQL("SELECT DAA.idArtista, I.id, A.nombre as nom, I.nombre, I.personaje, ACT.nomEvento\r\nFROM DETALLE_ACTIVIDAD_ARTISTA DAA LEFT JOIN ARTISTA A ON DAA.idArtista = A.id\r\nLEFT JOIN INTEGRANTE I ON A.id = I.idArtista\r\nLEFT JOIN ACTIVIDAD ACT ON DAA.idTipoActividad = ACT.id\r\nWHERE ACT.id =" + a.ID);
                string nombre = ds.Tables[0].Rows[0]["nom"].ToString();
                int idev = int.Parse(ds.Tables[0].Rows[0]["idArtista"].ToString());
                if (a is Evento)
                {
                    Evento e = (Evento)a;
                    e.Artistas = new List<Artista>();
                    if (ds.Tables[0].Rows[0]["nombre"].ToString().IsNullOrEmpty())
                    {

                        Artista ar = new Artista(idev, nombre);
                        e.Artistas.Add(ar);
                    }
                    else if (ds.Tables[0].Rows[0]["personaje"].ToString().IsNullOrEmpty())
                    {
                        Grupo g = new Grupo(idev, nombre);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            int id = int.Parse(ds.Tables[0].Rows[i]["id"].ToString());
                            string nom = ds.Tables[0].Rows[i]["nombre"].ToString();
                            Integrante inte = new Integrante(id, nom);
                            g.Integrantes.Add(inte);
                        }
                        e.Artistas.Add(g);
                    }

                    else
                    {
                        Reparto g = new Reparto(idev, nombre);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            int id = int.Parse(ds.Tables[0].Rows[i]["id"].ToString());
                            string nom = ds.Tables[0].Rows[i]["nombre"].ToString();
                            string personaje = ds.Tables[0].Rows[i]["personaje"].ToString();
                            Actor inte = new Actor(id, nombre, personaje);
                            g.Actores.Add(inte);
                        }
                        e.Artistas.Add(g);
                    }
                }
            }
        }//no listo
    }
}
