using AppExemploSRP.Domain;
using AppExemploSRP.Model;
using AppExemploSRP.Service;

ClienteViolacaoSRP cliente = new ClienteViolacaoSRP("José das Couves", "Rua das Flores, 123", "11987654321");
cliente.EnviarEmail("José das Alfaces" , "josedosalfaces@gmail.com");
cliente.GerarFatura();
cliente.SalvarCliente();
cliente.Validar();

//Cliente cliente2 = new Cliente("Maria das Alfaces");
//Cliente cliente3 = new Cliente();
//cliente3.Nome = "João das Alfaces";

Cliente cliente1 = new Cliente("José das couves", "Rua das Flores, 123", "11987654321");

ClienteValidadorService clienteValidador = new ClienteValidadorService();
clienteValidador.Validacao(cliente1);