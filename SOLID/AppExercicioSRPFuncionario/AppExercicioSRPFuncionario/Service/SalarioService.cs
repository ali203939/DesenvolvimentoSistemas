using AppExercicioSRPFuncionario.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioSRPFuncionario.Service
{
    public class SalarioService
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            double salarioBase = 0;

            switch(funcionario.cargo.ToLower())
            {
                case "gerente":
                    salarioBase = 5000;
                    Console.WriteLine("Cargo: Gerente, Salário Base: " + salarioBase);
                    break;
                case "analista":
                    salarioBase = 3000;
                    Console.WriteLine("Cargo: Analista, Salário Base: " + salarioBase);
                    break;
                case "desenvolvedor":
                    salarioBase = 2000;
                    Console.WriteLine("Cargo: Desenvolvedor, Salário Base: " + salarioBase);
                    break;
                default:
                    salarioBase = 1500;
                    break;
            }

            double salarioTotal = salarioBase * funcionario.horasTrabalhadas;
            return salarioTotal;
        }
    }
}