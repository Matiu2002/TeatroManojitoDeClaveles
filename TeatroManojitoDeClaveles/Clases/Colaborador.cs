using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Colaborador
    {
        private int id;
        private string nombre;

        public Colaborador()
        {
            id = 0;
            nombre = "NA";
        }

        public Colaborador(int id, string n)
        {
            this.id = id;
            nombre = n;
        }
        public Colaborador(Colaborador c)
        {
            id = c.id;
            nombre = c.nombre;
        }
    }
}
