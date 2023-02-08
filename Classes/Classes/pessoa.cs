using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //class, molde/modelo que comtêm propriedades e funcionalidade
    internal class pessoa
    {
        //propriedades
        public string nome;
        public string apelido;
        public int idade;
        public string cor_cabelo;

        //funcionalidades
        //public sera apresentado a todos os objetos criados apartir da classe
        public void Speak()
        {
            System.Windows.Forms.MessageBox.Show("Hello!, i am " + nome + ", i have " + idade + " years old and i am newbie!");
            Jump();
        }
        //privado penas apresentado em outros metodos
        private void Jump()
        {
            System.Windows.Forms.MessageBox.Show("SALTAR");
        }

        public void Identify()
        {
            System.Windows.Forms.MessageBox.Show(NameConstructor());
        }

        private string NameConstructor()
        {
            string nome_completo = nome + " " + apelido;
            return nome_completo;
            
        }
        //ref faz com que seja usada a mesma posicao de memoria ou seja a mesma variavel
        //valor entra no metodo AddOne e mesmo sendo um void a variavel é atualizada
        //pois ref usa a mesmo posicao da memoria.
        public void AddOne(ref int n) { n++; }
    }
}
