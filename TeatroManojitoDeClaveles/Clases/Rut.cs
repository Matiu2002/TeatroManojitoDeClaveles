using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroManojitoDeClaveles.Clases
{
    public class Rut
    {
        //atributos
        private int numero;
        private char dVerificador;

        //Métodos
        //1. Constructores
        public Rut()
        {
            //0-0  ==> Vacío
            this.numero = 0;
            this.dVerificador = '0';
        }

        public Rut(int num)
        {
            this.numero = num;
            this.dVerificador = CalcularDV();
        }

        public Rut(Rut r)
        {
            this.numero = r.numero;
            this.dVerificador = r.dVerificador;
        }

        //strRut = "dddddddd-V"
        public Rut(string strRut)
        {
            string[] datos = strRut.Split('-');
            if (datos.Length == 0)
            {
                //error
                this.numero = 0;
                this.dVerificador = '0';
            }
            else
            {
                try
                {
                    this.numero = int.Parse(datos[0]);
                    this.dVerificador = char.ToUpper(datos[1][0]);
                }
                catch (FormatException e)
                {
                    this.numero = 0;
                    this.dVerificador = '0';
                }

                if (!EsValido())
                {
                    this.numero = 0;
                    this.dVerificador = '0';
                }
            }

        }

        public bool EsValido()
        {
            char dv = CalcularDV();
            return dv == this.dVerificador;

        }

        public override string ToString()
        {
            return numero + "-" + dVerificador;
        }


        public char CalcularDV()
        {
            int n = this.numero;
            int factor = 2;
            int suma = 0;
            int digito;

            while (n > 0)
            {
                digito = n % 10;
                suma = suma + digito * factor;
                factor++;
                if (factor > 7)
                {
                    factor = 2;
                }
                n = n / 10;
            }

            int dv = 11 - suma % 11;

            char digVerif;
            switch (dv)
            {
                case 11:
                    digVerif = '0';
                    break;
                case 10:
                    digVerif = 'K';
                    break;
                default:
                    digVerif = (char)(48 + dv); //1..9
                    break;
            }

            return digVerif;

        }
    }
}
