namespace AppExemploDIP.Model
{
    public class TurmaPresencial : ITurma
    {
        public string Nome { get; set; }

        public string Periodo { get; set; }
        public string Sala { get; set; }

        public TurmaPresencial(string nome, string periodo, string sala)
        {
            Nome = nome;
            Periodo = periodo;
            Sala = sala;
        }

        public string GetInformacoesTurma()
        {
            return $"{Nome} - {Periodo} | Sala: {Sala}";
        }
    }
}
