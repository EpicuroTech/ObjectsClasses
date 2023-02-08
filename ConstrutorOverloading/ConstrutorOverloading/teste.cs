using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorOverloading
{
    internal class teste
    {
        string _nome;
        int _idade;


        //uso de construtor. PS: desta forma tenho que na criacao de novo objeto
        //passar por parametro as variaveis
        public teste(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        //Overload o mesmo metodo com varias assinaturas!
        //===========
        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(_nome + "->" + _idade);
        }
        //===========
        public void Apresentar(string separador)
        {
            System.Windows.Forms.MessageBox.Show(_nome + separador + _idade);
        }
        public void Apresentar(string separador, int idade)
        {
            System.Windows.Forms.MessageBox.Show(_nome + separador + idade);
        }
    }
}
