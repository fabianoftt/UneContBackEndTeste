namespace UneCont.Aplication.Controllers.Consulta
{
    public class ConsultaTodasNotaFiscalResponse
    {
        public ConsultaTodasNotaFiscalResponse()
        {
            NotaFiscal = new List<DtoNotaFiscal>();
        }
        public List<DtoNotaFiscal> NotaFiscal { get; set; }
        public int QuantidadeRegistro { get { return NotaFiscal.Count(); } }
    }

    public class DtoNotaFiscal
    {
        public long NumeroNotaFiscal { get; set; }
        public string? NomeCliente { get; set; }
        public decimal ValorNotaFiscal { set; get; }

        public string ValorNotaFiscalFormatado { get { return ValorNotaFiscal.ToString("C2"); } }
        public DateTime? DataEmissao { get; set; }
        public DateTime DataCadastroNotaFiscal { get; set; }
    }
}
