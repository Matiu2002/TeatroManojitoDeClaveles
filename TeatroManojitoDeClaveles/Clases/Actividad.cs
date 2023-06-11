using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroManojitoDeClaveles.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TeatroManojitoDeClaveles.Clases
{
    internal class Actividad
    {
        protected int id;
        protected DateTime fecha;
        protected string horario;
        protected int numero_participantes;
        protected ETipoActividad tipo;
        protected int costo_actividad;

        public Actividad()
        {
            id = 0;
            fecha = DateTime.Today;
            horario = "Sin definir";
            numero_participantes = 50;
            tipo = new ETipoActividad();
            costo_actividad = 50000;
        }
        public Actividad(int id, string f, string h, int n, string t, int c)
        {
            this.id = id;
            fecha = DateTime.Parse(f);
            horario = h;
            numero_participantes = n;
            //tipo revisar;
            costo_actividad = c;
        }
        public Actividad(string a)
        {
            string[] campo = a.Split(',');
            int.TryParse(campo[0], out id);
            fecha = DateTime.Parse(campo[1]);
            horario = campo[2];
            numero_participantes = int.Parse(campo[3]);
            //tipo revisar;
            costo_actividad = int.Parse(campo[5]);
        }
        public Actividad(Actividad a)
        {
            id = a.id;
            fecha = a.fecha;
            horario = a.horario;
            numero_participantes = a.numero_participantes;
            tipo = a.tipo;
            costo_actividad = a.costo_actividad;
        }
    }
}
