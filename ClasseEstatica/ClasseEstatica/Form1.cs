using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = estatica.NomePrograma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal ob1 = new normal();
            ob1.Nome = "Carlos Dias";
            ob1.ApresentarNome();

            normal ob2= new normal();
            ob2.Nome = "Dias Carlos";
            ob2.ApresentarNome();

            estatica.Nome = "Claudia";
            estatica.ApresentarNome();
            estatica.Nome = "Vicente";
            estatica.ApresentarNome();
        }
    }
}
