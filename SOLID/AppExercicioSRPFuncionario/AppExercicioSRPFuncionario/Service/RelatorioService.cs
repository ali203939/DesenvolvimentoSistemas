using AppExercicioSRPFuncionario.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioSRPFuncionario.Service
{
    public class RelatorioService
    {
            public void GerarRelatorio(Funcionario funcionario)
            {
                Console.WriteLine("----------Relatório do Funcionário---------");
                Console.WriteLine($"Nome: {funcionario.nome}");
                Console.WriteLine($"Cargo: {funcionario.cargo}");
                Console.WriteLine($"Horas Trabalhadas: {funcionario.horasTrabalhadas}");
        }
    }
}
