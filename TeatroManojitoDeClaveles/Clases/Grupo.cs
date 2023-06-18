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
        public Grupo()
        {
            id = 0;
            nombre = "NA";
            nacionalidad = "NA";
            cobro = 50000;
            integrantes = new List<Integrante>();
        }
        public Grupo(int id, string no, string na, int c)
        {
            this.id = id;
            nombre = no;
            nacionalidad = na;
            cobro = c;
            integrantes = new List<Integrante>();
        }
        public Grupo(Grupo g)
        {
            id = g.id;
            nombre = g.nombre;
            nacionalidad = g.nacionalidad;
            cobro = g.cobro;
            integrantes = g.integrantes;
        }
    }
}
