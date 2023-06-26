using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroManojitoDeClaveles.Enum;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Evento_FB : Evento
    {
        private List<Colaborador> colaboradores;
        private List<string> instituciones_invitadas;
        private string razon;
        public Evento_FB()
        {
            id = 0;
            fecha = DateTime.Today;
            horario = "Sin definir";
            nombre = "Sin definir";
            tipo = "Sin definir";
            costo_actividad = 50000;
            capacidad = 10000;
            artistas = new List<Artista>();
            entradas_disponibles = 10000;
            valores = new ValoresTickets();
            colaboradores = new List<Colaborador>();
            instituciones_invitadas = new List<string>();
        }
        public Evento_FB(int id, string f, string h, string n, string t, int c, int ca, int ed, string r)
        {
            this.id = id;
            fecha = DateTime.Parse(f);
            horario = h;
            nombre = n;
            tipo = t;
            costo_actividad = c;
            capacidad = ca;
            artistas = new List<Artista>();
            entradas_disponibles = ed;
            valores = new ValoresTickets();
            colaboradores = new List<Colaborador>();
            instituciones_invitadas = new List<string>();
            razon = r;
        }
        public Evento_FB(Evento_FB e)
        {
            id = e.id;
            fecha = e.fecha;
            horario = e.horario;
            nombre = e.nombre;
            tipo = e.tipo;
            costo_actividad = e.costo_actividad;
            capacidad = e.capacidad;
            artistas = e.artistas;
            entradas_disponibles = e.entradas_disponibles;
            valores = e.valores;
            colaboradores = e.colaboradores;
            instituciones_invitadas = e.instituciones_invitadas;
            razon = e.razon;
        }
    }
}
