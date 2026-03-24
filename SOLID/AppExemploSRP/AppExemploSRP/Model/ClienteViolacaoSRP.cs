namespace AppExemploSRP.Model
{
    public class ClienteViolacaoSRP
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public ClienteViolacaoSRP(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public ClienteViolacaoSRP(string nome)
        {
            Nome = nome;
        }

        public ClienteViolacaoSRP()
        {
        }

        public bool Validar()
        {
            return true;
        }

        public string GerarFatura()
        {
            string fatura = string.Empty;
            return fatura;
        }

        public string SalvarCliente()
        {
            return ("Cliente salvo no banco de dados.");
        }

        public void EnviarEmail(string nome, string email)
        {
            Console.WriteLine($"Email enviado para o cliente: {nome} no email: {email}");
        }
    }
}
