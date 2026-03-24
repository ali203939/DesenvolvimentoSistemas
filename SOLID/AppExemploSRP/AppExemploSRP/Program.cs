using AppExemploSRP.Domain;
using AppExemploSRP.Model;
using AppExemploSRP.Service;

//ClienteViolacaoSRP cliente = new ClienteViolacaoSRP("José das Couves", "Rua das Flores, 123", "11987654321");
//cliente.EnviarEmail("José das Alfaces", "josedosalfaces@gmail.com");
//cliente.GerarFatura();
//cliente.SalvarCliente();
//cliente.Validar();

Cliente cliente = new Cliente("Maria das Alfaces", "Rua das Flores, 123", "11987654321");
ClienteValidadorService validar = new ClienteValidadorService();
NotificacaoService notificacao = new NotificacaoService();
FaturaService faturaService = new FaturaService();

if (validar.Validacao(cliente))
{
    string fatura = faturaService.GerarFatura(cliente);
    Console.WriteLine(fatura);
    notificacao.EnviarSMS(cliente);
    notificacao.EnviarEmail(cliente, "Teste@gmail.com");
}