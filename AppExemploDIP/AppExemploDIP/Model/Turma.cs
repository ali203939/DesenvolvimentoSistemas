namespace AppExemploDIP.Model
{
    public class Turma
    {
        public Turma(string nome, string periodo)
        {
            Nome = nome;
            Periodo = periodo;
        }

        public string Nome { get; set; }
        public string Periodo { get; set; }

        public string GetInformacoesTurma()
        {
            return $"{Nome} - {Periodo}";
        }
    }
}
