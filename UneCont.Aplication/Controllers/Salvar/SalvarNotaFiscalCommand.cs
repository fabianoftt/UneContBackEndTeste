using MediatR;
using System.ComponentModel.DataAnnotations;

namespace UneCont.Aplication.Controllers.Salvar
{
    public class SalvarNotaFiscalCommand : IRequest<SalvarNotaFiscalResponse>
    {
        [Required(ErrorMessage = $"{nameof(NumeroNotaFiscal)} é obrigatório")]
        public long NumeroNotaFiscal { get; set; }
        
        [Required(ErrorMessage = $"{nameof(ValorNotaFiscal)} é obrigatório")]
        [Range(0.00, double.MaxValue, ErrorMessage = "{0} deve ser maior ou igual a zero")]
        public decimal ValorNotaFiscal { get; set; }
        
        [Required(ErrorMessage = $"{nameof(NomeCliente)} é obrigatório")]
        public string? NomeCliente { get; set; }
        
        [Required(ErrorMessage = $"{nameof(DataEmissao)} é obrigatório")]
        public DateTime DataEmissao { get; set; }
    }
}
