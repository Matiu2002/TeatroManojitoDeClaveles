using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Teatro
    {
        private string nombre;
        private string direccion;
        private int utilidades;
        private List<Pared> paredes;
        private List<Colaborador> colaboradores;
        private bool abiertoOCerrado;
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
            abiertoOCerrado = true;
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
            abiertoOCerrado = aoc;
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
            bool.TryParse(campo[3], out abiertoOCerrado);
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
            abiertoOCerrado = t.abiertoOCerrado;
            actividades = t.actividades;
            clientes = t.clientes;
            tickets = t.tickets;
            empleados = t.empleados;
        }
    }
}
