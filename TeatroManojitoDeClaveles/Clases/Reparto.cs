using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Reparto : Artista
    {
        private List<Actor> reparto;
        public List<Actor> Actores
        {
            get { return reparto; }
            set { reparto = value; }
        }
        public Reparto()
        {
            id = 0;
            nombre = "NA";
            reparto = new List<Actor>();
        }
        public Reparto(int id, string no)
        {
            this.id = id;
            nombre = no;
            reparto = new List<Actor>();
        }
        public Reparto(Reparto r)
        {
            id = r.id;
            nombre = r.nombre;
            reparto = r.reparto;
        }
    }
}
