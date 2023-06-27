using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Integrante
    {
        private int id;
        private string nombre;
        public Integrante()
        {
            id = 0;
            nombre = "NA";
        }
        public Integrante(int id, string no)
        {
            this.id = id;
            nombre = no;
        }
        public Integrante(Integrante a)
        {
            id = a.id;
            nombre = a.nombre;
        }
    }
}
