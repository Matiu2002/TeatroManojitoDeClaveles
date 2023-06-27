using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Actor
    {
        private int id;
        private string nombre;
        private string personaje;
        public Actor()
        {
            id = 0;
            nombre = "NA";
            personaje = "NA";
        }
        public Actor(int id, string no, string p)
        {
            this.id = id;
            nombre = no;
            personaje = p;
        }
        public Actor(Actor a)
        {
            id = a.id;
            nombre = a.nombre;
            personaje = a.personaje;
        }
    }
}
