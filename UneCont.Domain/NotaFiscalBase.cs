namespace UneCont.Domain
{
    public abstract class NotaFiscalBase
    {
        public long NumeroNotaFiscal { get; protected set; }
        public string? NomeCliente { get; protected set; }
        public decimal ValorNotaFiscal { get; protected set; }
        public DateTime? DataEmissao { get; protected set; }
        public DateTime DataCadastroNotaFiscal { get; protected set; }
    }
}
