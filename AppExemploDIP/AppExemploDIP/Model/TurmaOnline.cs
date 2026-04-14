namespace AppExemploDIP.Model
{
    public class TurmaOnline : ITurma
    {

        public string Nome { get; set; }

        public string Periodo { get; set; }
        public string Link { get; set; }

        public TurmaOnline(string nome, string periodo, string link)
        {
            Nome = nome;
            Periodo = periodo;
            Link = link;
        }

        public string GetInformacoesTurma()
        {
            return $"{Nome} - {Periodo} | link de acesso: {Link}";
        }
    }
}