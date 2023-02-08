using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_ligeiro carro = new cl_ligeiro();
            carro.velocidade_maxima = 120;//caracteristica exclusivo de ligeiros
            cl_bicicleta bike= new cl_bicicleta();
            //bike.Pedalar();//metodo exclusivo de bicicletas
            carro.Acelerar();
            bike.Acelerar();
            carro.Parar();
            bike.Parar();
        }
    }
}
