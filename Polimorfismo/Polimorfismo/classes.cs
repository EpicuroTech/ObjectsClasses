using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract class forma_geo
    {
        int _largura, _altura;

        //construtores
        public int Largura { get { return _largura; } set { _largura = value; } }
        public int Altura { get { return _altura;} set { _altura = value; } }
        
        //metodos
        public void Apresentar()
        {
            Console.WriteLine("este metodo pertence á classe base");

        }
        //este metodo tera que ser implementado em todas as classes derivadas
        public abstract void Desenhar();

        public virtual void Desenhar_virt()
        { Console.WriteLine("Metodo virtual da classe base, pode ou nao ser defenido na classe derivada"); }


    }

    //================

    class rectangulo : forma_geo
    {
        public override void Desenhar()
        { 
            Console.WriteLine("desenhar rectangulo com as dimensoes: "+ Largura + "x" + Altura); 
        }
        public override void Desenhar_virt()
        {
            Console.WriteLine("novo metodo virtual substituido");
        }
    }
    class triangulo : forma_geo
    {
        public override void Desenhar()
        {
            Console.WriteLine("desenhar triangulo com as dimensoes: " + Largura + "x" + Altura);
        }
    }
    class circulo : forma_geo
    {
        public override void Desenhar()
        {
            Console.WriteLine("desenhar circulo com as dimensoes: " + Largura + "x" + Altura);
        }
    }
}
