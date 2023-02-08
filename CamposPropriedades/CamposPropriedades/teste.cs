using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposPropriedades
{
    internal class teste
    {
        //defeniçao de um CAMPO/FIELD, será privado, apenas visivel dentro da class teste
        string _nome;
        int _idade;

        //defeniçao de uma PROPRIEDADE
        //public string Nome
        //{
        //    //define nome
        //    set 
        //    {
        //        //desta forma podemos codificar mecanismos de validação de dados!
        //        if (value == null)
        //            _nome = "Tem que inserir nome!";
        //        else
        //            _nome = value;
        //    }
        //    //devolve nome
        //    get 
        //    {
        //        return _nome;
        //    }
        //}

        //Se nao precisar de validaçao de dados isto seria o suficiente!
        public string Nome
        {
      
            set{ _nome = value; }
            get{return _nome;}
        }
        //ou simplesmente desda forma mas não usa a variavel _nome
        //public string Nome { get; set; }

        //metodos
        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(_nome);
        }
    }
}
