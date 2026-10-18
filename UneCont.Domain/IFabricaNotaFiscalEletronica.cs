namespace UneCont.Domain
{
    public interface IFabricaNotaFiscalEletronica
    {
        NotaFiscalEletronica CriarNotaFiscal(long numero, string? nomeCliente, decimal valorNotaFiscal, DateTime? dataEmissao, int numeroProcessoEletronico);
    }
}
