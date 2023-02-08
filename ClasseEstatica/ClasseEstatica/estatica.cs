using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    //fica acessivel a todo ao projeto, nao se pode criar objetos apartir de classe estatica
    public static class estatica
    {
        public static string Nome;

        public static string NomePrograma = "Aplicação de teste";
        public static void ApresentarNome()
        {
            Console.WriteLine(Nome);
        }
    }
}
