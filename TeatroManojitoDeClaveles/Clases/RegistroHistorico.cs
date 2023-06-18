using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class RegistroHistorico
    {
        private int id;
        private int cantPersonas;
        private string periodo;
        public RegistroHistorico()
        {
            id = 0;
            cantPersonas = 0;
            periodo = "0";
        }
        public RegistroHistorico(int id, int cantPersonas, string periodo)
        {
            this.id = id;
            this.cantPersonas = cantPersonas;
            this.periodo = periodo;
        }
        public RegistroHistorico(RegistroHistorico r)
        {
            id = r.id;
            cantPersonas = r.cantPersonas;
            periodo = r.periodo;
        }
    }
}
