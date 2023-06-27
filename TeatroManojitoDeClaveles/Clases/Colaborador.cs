using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Colaborador
    {
        private int id, financiamiento;
        private float finanPorcentual;
        private string nombre;

        public Colaborador()
        {
            id = 0;
            nombre = "NA";
        }

        public Colaborador(int id, string n, float finanPorcentual, int financiamiento)
        {
            this.id = id;
            nombre = n;
            this.finanPorcentual = finanPorcentual;
            this.financiamiento = financiamiento;
        }
        public Colaborador(Colaborador c)
        {
            id = c.id;
            nombre = c.nombre;
            this.finanPorcentual = c.finanPorcentual;
            this.financiamiento = c.financiamiento;
        }
    }
}
