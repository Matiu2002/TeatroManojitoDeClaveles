using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroManojitoDeClaveles.Enum;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Ticket
    {
        private int id_ticket;
        private int id_evento;
        private Rut rut_cliente;
        private ETipoTicket tipo;
        private int valor;
        private bool estado;
        public Ticket()
        {
            id_ticket = 0;
            id_evento = 0;
            rut_cliente = new Rut();
            tipo = new ETipoTicket();
            valor = 0;
            estado = true;
        }
        public Ticket(int id_ticket, int id_evento, Rut rut_cliente, ETipoTicket tipo, int valor, bool estado)
        {
            this.id_ticket = id_ticket;
            this.id_evento = id_evento;
            this.rut_cliente = rut_cliente;
            this.tipo = tipo;
            this.valor = valor;
            this.estado = estado;
        }
        public Ticket(Ticket t)
        {
            this.id_ticket = t.id_ticket;
            this.id_evento = t.id_evento;
            this.rut_cliente = t.rut_cliente;
            this.tipo = t.tipo;
            this.valor = t.valor;
            this.estado = t.estado;
        }
    }
}
