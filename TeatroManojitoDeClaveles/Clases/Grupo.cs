using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Grupo : Artista
    {
        private List<Integrante> integrantes;
        public List<Integrante> Integrantes
        {
            get { return integrantes; }
            set { integrantes = value; }
        }
        public Grupo()
        {
            id = 0;
            nombre = "NA";
            integrantes = new List<Integrante>();
        }
        public Grupo(int id, string no)
        {
            this.id = id;
            nombre = no;
            integrantes = new List<Integrante>();
        }
        public Grupo(Grupo g)
        {
            id = g.id;
            nombre = g.nombre;
            integrantes = g.integrantes;
        }
    }
}
