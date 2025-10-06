using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.SOLID
{
    //SINGLE RESPONSABILITY PRINCIPLE

    //Afirma que uma classe deve ter apenas uma responsabilidade
    public class SRP_GeradorRelatorio
    {
        public string Gerar()
        {
            Console.WriteLine("Gerando relatório...");
            return "Conteúdo exibido!";
        }
    }

    public class RelatorioPersistir
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine("Salvando relatório...");
        }
    }
}