using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class cl_bicicleta : cl_veiculo
    {
        //criar metodo abstract da heranca como override!
        public override void Acelerar()
        {
            Console.WriteLine("a bicicleta esta a pedalar com força!");
        }

        //cria metodo para substituir o parar, mas não é obrigatorio!!! caso nao seja
        //defenido usará o da herança, pois está como virtual
        public override void Parar()
        {
            Console.WriteLine("a bike travouuuuuuu!");
        }
        public void Pedalar()
        { }

    }
  
}
