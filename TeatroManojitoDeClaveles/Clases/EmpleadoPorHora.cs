using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class EmpleadoPorHora : Empleado
    {
        private int horasTrabajadas;
        private int pagoPorHora;
        private int idEvento;
        public EmpleadoPorHora()
        {
            id = 0;
            rut = new Rut();
            nombre = "NA";
            salario = 0;
            cargo = "NA";
        }
        public EmpleadoPorHora(int id, Rut rut, string no, int sal, string car)
        {
            this.id = id;
            this.rut = rut;
            nombre = no;
            salario = sal;
            cargo = car;
        }
        public EmpleadoPorHora(EmpleadoPorHora a)
        {
            this.id = a.id;
            rut = a.rut;
            nombre = a.nombre;
            salario = a.salario;
            cargo = a.cargo;
        }
    }
}
