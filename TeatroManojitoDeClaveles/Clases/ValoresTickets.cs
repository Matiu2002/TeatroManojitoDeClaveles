using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class ValoresTickets
    {
        private int c_platea_alta;
        private int v_platea_alta;
        private int c_platea_baja;
        private int v_platea_baja;
        private int c_balcon;
        private int v_balcon;
        private int c_galeria;
        private int v_galeria;
        public ValoresTickets()
        {
             c_platea_alta = 0;
             v_platea_alta = 0;
             c_platea_baja = 0;
             v_platea_baja = 0;
             c_balcon = 0;
             v_balcon = 0;
             c_galeria = 0;
             v_galeria = 0;
        }
        public ValoresTickets(int c_platea_alta, int v_platea_alta, int c_platea_baja, int v_platea_baja, int c_balcon, int v_balcon, int c_galeria, int v_galeria)
        {
            this.c_platea_alta = c_platea_alta;
            this.v_platea_alta = v_platea_alta;
            this.c_platea_baja = c_platea_baja;
            this.v_platea_baja = v_platea_baja;
            this.c_balcon = c_balcon;
            this.v_balcon = v_balcon;
            this.c_galeria = c_galeria;
            this.v_galeria = v_galeria;
        }
        public ValoresTickets(ValoresTickets v)
        {
            this.c_platea_alta = v.c_platea_alta;
            this.v_platea_alta = v.v_platea_alta;
            this.c_platea_baja = v.c_platea_baja;
            this.v_platea_baja = v.v_platea_baja;
            this.c_balcon = v.c_balcon;
            this.v_balcon = v.v_balcon;
            this.c_galeria = v.c_galeria;
            this.v_galeria = v.v_galeria;
        }
    }
}
