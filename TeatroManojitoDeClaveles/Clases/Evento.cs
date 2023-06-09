﻿using System;
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
        protected int entradas_disponibles;
        protected ValoresTickets valores;
        public List<Artista> Artistas
        {
            get { return artistas; }
            set { artistas = value; }
        }
        public ValoresTickets Valores
        {
            get { return valores; }
            set { valores = value; }
        }
        public Evento()
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
        }
        public Evento(int id, string f, string h, string n, string t, int c, int ca, int ed)
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
        }
        public Evento(Evento e)
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
        }
    }
}
