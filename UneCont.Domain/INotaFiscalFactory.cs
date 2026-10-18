namespace UneCont.Domain
{
    public interface INotaFiscalFactory
    {
        NotaFiscal CriarNotaFiscal(long numero, string? nomeCliente, decimal valorNotaFiscal, DateTime? dataEmissao);
    }
}
