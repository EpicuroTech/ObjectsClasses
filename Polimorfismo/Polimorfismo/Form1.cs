using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rectangulo rec = new rectangulo();
            triangulo tri  = new triangulo();
            circulo cir = new circulo();
            rec.Altura = 100;
            rec.Largura = 60;
            rec.Apresentar();
            rec.Desenhar();
            rec.Desenhar_virt();

            tri.Altura = 150;
            tri.Largura = 20;
            tri.Apresentar();
            tri.Desenhar();
            tri.Desenhar_virt();

            cir.Altura = 50;
            cir.Largura = 10;
            cir.Apresentar();
            cir.Desenhar();
            cir.Desenhar_virt();
        }
    }
}
