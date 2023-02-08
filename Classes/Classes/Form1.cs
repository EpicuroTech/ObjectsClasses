using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //class, molde/modelo que comtêm propriedades e funcionalidade

            pessoa p1 = new pessoa();
            p1.nome = "Carlos";
            p1.apelido = "Dias";
            p1.idade = 31;
            p1.cor_cabelo = "Castanho";
            //p1.Speak();
            p1.Identify();


            //ref faz com que seja usada a mesma posicao de memoria ou seja a mesma variavel
            //valor entra no metodo AddOne e mesmo sendo um void a variavel é atualizada
            //pois ref usa a mesmo posicao da memoria.
            int valor = 0;
            p1.AddOne(ref valor);
            label1.Text = valor.ToString();
        }
    }
}
