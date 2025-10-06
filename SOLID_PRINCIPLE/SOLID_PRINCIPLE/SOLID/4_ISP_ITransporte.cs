using SOLID_PRINCIPLE.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.SOLID
{
    // ISP Interface Segregation Principle

    //Nenhuma classe deve ser forçada a implementar interfaces que não utiliza.
    public interface ITransporteBasico
    {
        void Mover();

        void Parar();
    }

    public interface ITransporteComDirecao
    {
        void VirarDireita();

        void VirarEsquerda();
    }

    public interface ITransporteAereo
    {
        void Subir();

        void Descer();
    }
}

public class Carro : ITransporteBasico, ITransporteComDirecao
{
    public void Mover() => Console.WriteLine("Carro andando...");

    public void Parar() => Console.WriteLine("Carro parado.");

    public void VirarDireita() => Console.WriteLine("Carro virou à direita.");

    public void VirarEsquerda() => Console.WriteLine("Carro virou à esquerda.");
}

public class Aviao : ITransporteBasico, ITransporteComDirecao, ITransporteAereo
{
    public void Mover() => Console.WriteLine("Avião taxiando...");

    public void Parar() => Console.WriteLine("Avião parado.");

    public void VirarDireita() => Console.WriteLine("Virando pela asa direita.");

    public void VirarEsquerda() => Console.WriteLine("Virando pela asa esquerda.");

    public void Subir() => Console.WriteLine("Subindo...");

    public void Descer() => Console.WriteLine("Descendo...");
}