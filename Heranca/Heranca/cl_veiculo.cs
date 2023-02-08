using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    //abstract faz com que nao seja possivle criar objetos do tipo veiculo
    //pois é "incompleta" porque é uma super classe feita para ser herdada
    abstract class cl_veiculo
    {
        //defenido como propriedade, algo que podemos ir buscar e defenir
        public string cor { get; set; }
        public string marca { get; set; }

        //se colocar um metodo abstract isto faz com que seja obrigatório ter este metodo codificado nos "filhos"
        abstract public void Acelerar();

        //virtual pode ser usado e alterado
        public virtual void Parar()
        {
            Console.WriteLine("parou!!!");
        }

    }
}
