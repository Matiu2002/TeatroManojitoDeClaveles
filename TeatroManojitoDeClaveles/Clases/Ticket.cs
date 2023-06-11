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
    }
}
