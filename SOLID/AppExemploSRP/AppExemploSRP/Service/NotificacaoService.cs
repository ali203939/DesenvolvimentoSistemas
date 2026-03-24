using AppExemploSRP.Domain;

namespace AppExemploSRP.Service
{
    public class NotificacaoService
    {
        public string nome { get; set; }
        public string email { get; set; }

        public void EnviarEmail(Cliente cliente, string email)
        {
            Console.WriteLine($"Email enviado para {cliente.Nome} no endereço de email: {email}");
        }

        public void EnviarSMS(Cliente cliente)
        {
            Console.WriteLine($"SMS enviado para {cliente.Nome} no telefone: {cliente.Telefone}");
        }
    }
}
