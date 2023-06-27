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
        private string fecha;
        private string arrienda;
        public Pared()
        {
            id = 0;
            valor = 0;
            fecha = "N/A";
            arrienda = "N/A";
        }
        public Pared(int id, int valor, string fecha, string arrienda)
        {
            this.id = id;
            this.valor = valor;
            this.fecha = fecha;
            this.arrienda = arrienda;
        }
        public Pared(Pared p)
        {
            id = p.id;
            valor = p.valor;
            fecha = p.fecha;
            arrienda = p.arrienda;
        }
    }
}
