using AppExemploSRP.Domain;

namespace AppExemploSRP.Service
{
    public class FaturaService
    {
        
        public string GerarFatura(Cliente cliente)
        {
            string fatura = "";
            fatura = $"--------Fatura gerada com sucesso------------\r\n" +
                        $"Cliente: {cliente.Nome}\r\n" +
                        $"Endereço: {cliente.Endereco}\r\n" +
                        $"Telefone: {cliente.Telefone}\r\n" +
                        $"Data da geração da fatura: {DateTime.Now:dd/MM/yyyy}\r\n" +
                        $"-------------------------------------------";
            return fatura;
        }
    }
}
