using AppExercicioSRPFuncionario.Domain;
using AppExercicioSRPFuncionario.Service;

Funcionario funcionario = new Funcionario();
funcionario.nome = "João Silva";
funcionario.cargo = "Desenvolvedor";

SalarioService calcularSalario = new SalarioService();
RelatorioService gerarRelatorio = new RelatorioService();

calcularSalario.CalcularSalario(funcionario);
gerarRelatorio.GerarRelatorio(funcionario);