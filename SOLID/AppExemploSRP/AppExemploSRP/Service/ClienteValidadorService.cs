using AppExemploSRP.Domain;

namespace AppExemploSRP.Service
{
    public class ClienteValidadorService
    {
        public bool Valido { get; set; }
        public string Erros { get; set; }

        public bool Validacao(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                Console.WriteLine("O nome do cliente é obrigatório.");
                return false;
            }

            if (cliente.Nome.Trim().Length < 3)
            {
                Console.WriteLine("O nome do cliente deve conter pelo menos 3 caracteres.");
                return false;

            }

            Console.WriteLine("Dados do cliente válidados com sucesso.");
            return true;

        }


    }
}
