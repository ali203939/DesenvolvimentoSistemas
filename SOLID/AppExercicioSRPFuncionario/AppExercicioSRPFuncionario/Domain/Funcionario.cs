using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioSRPFuncionario.Domain
{
    public class Funcionario
    {

        public string nome { get; set; }
        public string cargo { get; set; }
        public int horasTrabalhadas { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string cargo, int horasTrabalhadas)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.horasTrabalhadas = horasTrabalhadas;
        }

    }
}
