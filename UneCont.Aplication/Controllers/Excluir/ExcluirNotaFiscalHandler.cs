using MediatR;
using UneCont.Infraestructure.Repository;

namespace UneCont.Aplication.Controllers.Excluir
{
    public class ExcluirNotaFiscalHandler : IRequestHandler<ExcluirNotaFiscalCommand, ExcluirNotaFiscalResponse>
    {
        private readonly IRepositoryNotaFiscal _repositoryNotaFiscal;

        public ExcluirNotaFiscalHandler(IRepositoryNotaFiscal repositoryNotaFiscal)
        {
            _repositoryNotaFiscal = repositoryNotaFiscal;
        }

        public async Task<ExcluirNotaFiscalResponse> Handle(ExcluirNotaFiscalCommand request, CancellationToken cancellationToken)
        {
            var response = new ExcluirNotaFiscalResponse();
            if (request.NumeroNotaFiscal > 0)
            {
                response.Sucesso = await _repositoryNotaFiscal.ExcluirNotaFiscal(request.NumeroNotaFiscal);
            }

            return response;
        }
    }
}
