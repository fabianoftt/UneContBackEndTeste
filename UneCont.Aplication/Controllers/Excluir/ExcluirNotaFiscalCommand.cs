using MediatR;

namespace UneCont.Aplication.Controllers.Excluir
{
    public class ExcluirNotaFiscalCommand : IRequest<ExcluirNotaFiscalResponse>
    {
        public long NumeroNotaFiscal { get; set; }
    }
}
