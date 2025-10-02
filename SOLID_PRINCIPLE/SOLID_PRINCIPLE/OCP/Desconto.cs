using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.OCP
{
    public abstract class Desconto
    {
        public abstract double Calcular(double valor);
    }

    public class DescontoEletronicos : Desconto
    {
        public override double Calcular(double valor) => valor * 0.1;
    }

    public class DescontoRoupas : Desconto
    {
        public override double Calcular(double valor) => valor * 0.2;
    }

    public class DescontoCalcados : Desconto
    {
        public override double Calcular(double valor) => valor * 0.3;
    }
}