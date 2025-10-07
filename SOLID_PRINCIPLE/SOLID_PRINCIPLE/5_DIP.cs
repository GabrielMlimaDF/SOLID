using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE
{
    //DIP DependencyInversion Principle
    //Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.
    //Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
    public interface INotificador
    {
        void Notificar(string mensagem);
    }

    public class EmailService : INotificador
    {
        public void Notificar(string mensagem)
        {
            Console.WriteLine($"Enviando email: {mensagem}");
        }
    }

    public class SmsService : INotificador
    {
        public void Notificar(string mensagem)
        {
            Console.WriteLine($"Enviando SMS: {mensagem}");
        }
    }

    public class PedidoService
    {
        private readonly INotificador _notificador;

        public PedidoService(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void RealizarPedido(string produto)
        {
            Console.WriteLine($"Pedido do produto {produto} realizado.");
            _notificador.Notificar("Seu pedido foi recebido!");
        }
    }
}