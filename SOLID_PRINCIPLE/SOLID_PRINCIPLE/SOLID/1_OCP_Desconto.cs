using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.SOLID
{
    //OPEN/CLOSE PRINCIPLE

    //Aberta para extensão e fechada para modificação
    public abstract class Ocp_Desconto
    {
        public abstract double Calcular(double valor);
    }

    public class DescontoEletronicos : Ocp_Desconto
    {
        public override double Calcular(double valor) => valor * 0.1;
    }

    public class DescontoRoupas : Ocp_Desconto
    {
        public override double Calcular(double valor) => valor * 0.2;
    }

    public class DescontoCalcados : Ocp_Desconto
    {
        public override double Calcular(double valor) => valor * 0.3;
    }
}