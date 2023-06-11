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
        private string nacionalidad;
        public Integrante()
        {
            id = 0;
            nombre = "NA";
            nacionalidad = "NA";
        }
        public Integrante(int id, string no, string na, string p)
        {
            this.id = id;
            nombre = no;
            nacionalidad = na;
        }
        public Integrante(Integrante a)
        {
            id = a.id;
            nombre = a.nombre;
            nacionalidad = a.nacionalidad;
        }
    }
}
