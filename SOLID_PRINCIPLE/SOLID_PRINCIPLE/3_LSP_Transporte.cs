using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE
{
    //Liskov Substitution Principle

    //Princípio afirma que objetos de uma classe derivada devem poder substituir objetos de sua classe base sem alterar a funcionalidade do programa.

    //O segredo é se perguntar se aquele método da classe faz sentido em todas as que vão derivar,
    //se não fizer sentido, o melhor é dividir em abstrações
    public abstract class Transporte
    {
        public abstract void Mover();

        public abstract void Parar();
    }

    public abstract class TransporteTerrestre : Transporte
    {
        public abstract void VirarDireita();

        public abstract void VirarEsquerda();
    }

    public class Carro : TransporteTerrestre
    {
        public override void Mover()
        {
            Console.WriteLine("Dirigindo em terra...");
        }

        public override void Parar()
        {
            Console.WriteLine("Carro parado.");
        }

        public override void VirarDireita()
        {
            Console.WriteLine("Virando à direita com o volante.");
        }

        public override void VirarEsquerda()
        {
            Console.WriteLine("Virando à esquerda com o volante.");
        }
    }

    public class Barco : Transporte
    {
        public override void Mover()
        {
            Console.WriteLine("Navegando na água...");
        }

        public override void Parar()
        {
            Console.WriteLine("Ancorando o barco.");
        }
    }
}