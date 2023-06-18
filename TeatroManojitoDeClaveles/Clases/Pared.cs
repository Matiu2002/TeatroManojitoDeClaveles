using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Pared
    {
        private int id;
        private int valor;
        private bool disponible;
        private string arrienda;
        public Pared()
        {
            id = 0;
            valor = 0;
            disponible = true;
            arrienda = "N/A";
        }
        public Pared(int id, int valor, bool disponible, string arrienda)
        {
            this.id = id;
            this.valor = valor;
            this.disponible = disponible;
            this.arrienda = arrienda;
        }
        public Pared(Pared p)
        {
            id = p.id;
            valor = p.valor;
            disponible = p.disponible;
            arrienda = p.arrienda;
        }
    }
}
