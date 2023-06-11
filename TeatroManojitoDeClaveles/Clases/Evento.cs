using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroManojitoDeClaveles.Enum;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Evento : Actividad
    {
        protected int capacidad;
        protected List<Artista> artistas;
        protected ETipoEvento tipoE;
        protected int entradas_disponibles;
        protected ValoresTickets valores;
        public Evento()
        {
            id = 0;
            fecha = DateTime.Today;
            horario = "Sin definir";
            numero_participantes = 50;
            tipo = new ETipoActividad();
            costo_actividad = 50000;
            capacidad = 10000;
            artistas = new List<Artista>();
            tipoE = new ETipoEvento();
            entradas_disponibles = 10000;
            valores = new ValoresTickets();
        }
        public Evento(int id, string f, string h, int n, string t, int c, int ca, string te, int ed)
        {
            this.id = id;
            fecha = DateTime.Parse(f);
            horario = h;
            numero_participantes = n;
            //tipo revisar;
            costo_actividad = c;
            capacidad = ca;
            artistas = new List<Artista>();
            //tipoE revisar;
            entradas_disponibles = ed;
            valores = new ValoresTickets();
        }
        public Evento(Evento e)
        {
            id = e.id;
            fecha = e.fecha;
            horario = e.horario;
            numero_participantes = e.numero_participantes;
            tipo = e.tipo;
            costo_actividad = e.costo_actividad;
            capacidad = e.capacidad;
            artistas = e.artistas;
            tipoE = e.tipoE;
            entradas_disponibles = e.entradas_disponibles;
            valores = e.valores;
        }
    }
}
