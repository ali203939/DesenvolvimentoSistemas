namespace AppExemploDIP.Model
{
    public interface ITurma
    {
        string Nome { get; }
        string Periodo { get; }

        string GetInformacoesTurma();
    }
}
