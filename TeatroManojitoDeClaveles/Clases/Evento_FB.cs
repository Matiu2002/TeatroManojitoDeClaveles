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
        public Evento_FB()
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
            colaboradores = new List<Colaborador>();
            instituciones_invitadas = new List<string>();
        }
        public Evento_FB(int id, string f, string h, int n, string t, int c, int ca, string te, int ed)
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
            colaboradores = new List<Colaborador>();
            instituciones_invitadas = new List<string>();
        }
        public Evento_FB(Evento_FB e)
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
            colaboradores = e.colaboradores;
            instituciones_invitadas = e.instituciones_invitadas;
        }
    }
}
