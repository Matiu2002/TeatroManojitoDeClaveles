using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroManojitoDeClaveles.Clases;
using TeatroManojitoDeClaveles.Páginas;

namespace TeatroManojitoDeClaveles
{
    public partial class Form1 : Form
    {
        public Teatro teatro;
        public Form1()
        {
            InitializeComponent();
            panPrincipal.Controls.Add(new Login_real());
        }
        public void LALA()
        {

        }
    }
}
