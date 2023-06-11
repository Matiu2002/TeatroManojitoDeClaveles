using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Artista
    {
        protected int id;
        protected string nombre;
        protected string nacionalidad;
        protected int cobro;
        public Artista()
        {
            id = 0;
            nombre = "NA";
            nacionalidad = "NA";
            cobro = 50000;
        }
        public Artista(int id, string no, string na, int c)
        {
            this.id = id;
            nombre = no;
            nacionalidad = na;
            cobro = c;
        }
        public Artista(Artista a)
        {
            id = a.id;
            nombre = a.nombre;
            nacionalidad = a.nacionalidad;
            cobro = a.cobro;
        }
    }
}