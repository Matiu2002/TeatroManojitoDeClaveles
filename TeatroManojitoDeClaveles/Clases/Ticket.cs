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
        private string tipo;
        private int valor;
        public Ticket()
        {
            id_ticket = 0;
            id_evento = 0;
            rut_cliente = new Rut();
            tipo = "N/A";
            valor = 0;
        }
        public Ticket(int id_ticket, int id_evento, Rut rut_cliente, string tipo, int valor)
        {
            this.id_ticket = id_ticket;
            this.id_evento = id_evento;
            this.rut_cliente = rut_cliente;
            this.tipo = tipo;
            this.valor = valor;
        }
        public Ticket(Ticket t)
        {
            this.id_ticket = t.id_ticket;
            this.id_evento = t.id_evento;
            this.rut_cliente = t.rut_cliente;
            this.tipo = t.tipo;
            this.valor = t.valor;
        }
    }
}
