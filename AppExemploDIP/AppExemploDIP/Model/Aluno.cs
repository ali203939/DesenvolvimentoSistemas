namespace AppExemploDIP.Model
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public ITurma Turma { get; set; }

        public Aluno(string nome, string matricula, ITurma turma)
        {
            Nome = nome;
            Matricula = matricula;
            Turma = turma;
        }
        public void ExibirInformarcoesAluno()
        {
            Console.WriteLine($"[{Matricula}] {Nome} -> {Turma.GetInformacoesTurma()}");
        }

    }
}
