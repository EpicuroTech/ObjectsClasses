using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    //herdou as restantes propriedades de veiculo e agr acrescentamos mas propriedades
    //que sao especidficas do ligeiro
    internal class cl_ligeiro : cl_veiculo
    {
        //criar metodo abstract da heranca como override!
        public override void Acelerar()
        {
            Console.WriteLine("o carro vai prego a fundo!");
        }
        public int velocidade_maxima { get; set; }

    }
}
