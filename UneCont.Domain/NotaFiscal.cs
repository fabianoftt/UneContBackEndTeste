namespace UneCont.Domain
{
    public sealed class NotaFiscal : NotaFiscalBase
    {
        internal NotaFiscal(long numero, string nomeCliente, decimal valorNotaFiscal, DateTime? dataEmissao)
        {
            NumeroNotaFiscal = numero;
            NomeCliente = nomeCliente;
            ValorNotaFiscal = valorNotaFiscal;
            DataEmissao = dataEmissao;
            DataCadastroNotaFiscal = DateTime.Now;
        }
    }
}
