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
        public Artista()
        {
            id = 0;
            nombre = "NA";
        }
        public Artista(int id, string no)
        {
            this.id = id;
            nombre = no;
        }
        public Artista(Artista a)
        {
            id = a.id;
            nombre = a.nombre;
        }
    }
}