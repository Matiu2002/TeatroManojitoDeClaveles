using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Empleado
    {
        protected int id;
        protected Rut rut;
        protected string nombre;
        protected int salario;
        protected string cargo;
        public Empleado()
        {
            id = 0;
            rut = new Rut();
            nombre = "NA";
            salario = 0;
            cargo = "NA";
        }
        public Empleado(int id, Rut rut, string no, int sal, string car)
        {
            this.id = id;
            this.rut = rut;
            nombre = no;
            salario = sal;
            cargo = car;
        }
        public Empleado(Empleado a)
        {
            this.id = a.id;
            rut = a.rut;
            nombre = a.nombre;
            salario = a.salario;
            cargo = a.cargo;
        }
    }
}
