using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.SRP
{
    public class GeradorRelatorio
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