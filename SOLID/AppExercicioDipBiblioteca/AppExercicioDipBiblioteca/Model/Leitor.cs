using AppExercicioDipBiblioteca.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioDipBiblioteca.Model
{
    public class Leitor
    {
        public string Nome { get; set; }
        public string Registro { get; set; }

        // 🔴 Dependência concreta — problema a ser resolvido
        public IAcervo AcervoEmprestado { get; set; }

        public Leitor(string nome, string registro, IAcervo acervo)
        {
            Nome = nome;
            Registro = registro;
            AcervoEmprestado = acervo;
        }

        public void ExibirEmprestimo()
        {
            Console.WriteLine(
                $"Leitor: {Nome} ({Registro}) | Item: {AcervoEmprestado.GetInfo()}"
            );
        }
    }
}
