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
        public Reparto()
        {
            id = 0;
            nombre = "NA";
            nacionalidad = "NA";
            cobro = 50000;
            reparto = new List<Actor>();
        }
        public Reparto(int id, string no, string na, int c)
        {
            this.id = id;
            nombre = no;
            nacionalidad = na;
            cobro = c;
            reparto = new List<Actor>();
        }
        public Reparto(Reparto r)
        {
            id = r.id;
            nombre = r.nombre;
            nacionalidad = r.nacionalidad;
            cobro = r.cobro;
            reparto = r.reparto;
        }
    }
}
