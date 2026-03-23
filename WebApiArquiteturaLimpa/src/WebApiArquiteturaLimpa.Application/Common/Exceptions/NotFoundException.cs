namespace WebApiArquiteturaLimpa.Application.Common.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string entityName, object key)
        : base($"Entidade '{entityName}' com chave '{key}' não foi encontrada.") { }
}
