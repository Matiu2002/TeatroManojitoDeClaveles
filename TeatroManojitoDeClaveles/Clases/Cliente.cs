using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroManojitoDeClaveles.Enum;

namespace TeatroManojitoDeClaveles.Clases
{
    public class Cliente
    {
        private int id;
        private Rut cliente;
        private string nombreCompleto;
        private string correo;
        private string membresia;
        public string Membresia
        {
            get { return membresia; }
            set { membresia = value; }
        }
        public Cliente()
        {
            cliente = new Rut();
            nombreCompleto = "NA";
            membresia = "NA";
        }
        public Cliente(int id, Rut cliente, string no, string co, string p)
        {
            this.id = id;
            this.cliente = cliente;
            nombreCompleto = no;
            correo = co;
            membresia = p;
        }
        public Cliente(Cliente a)
        {
            this.id = a.id;
            cliente = a.cliente;
            nombreCompleto = a.nombreCompleto;
            correo = a.correo;
            membresia = a.membresia;
        }
    }
}
