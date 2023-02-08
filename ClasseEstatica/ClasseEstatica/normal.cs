using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    //class normal, precisa de ser instanciada, ou seja, é necessária a criaçao de um objeto
    internal class normal
    {
        public string Nome { get; set; }

        public void ApresentarNome()
        {
            Console.WriteLine(Nome);
        }
    }
}
