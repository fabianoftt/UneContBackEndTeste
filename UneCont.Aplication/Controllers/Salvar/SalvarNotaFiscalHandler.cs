using MediatR;
using UneCont.Domain;
using UneCont.Infraestructure.Repository;

namespace UneCont.Aplication.Controllers.Salvar
{
    public class SalvarNotaFiscalHandler : IRequestHandler<SalvarNotaFiscalCommand, SalvarNotaFiscalResponse>
    {
        private readonly INotaFiscalFactory _notaFiscalfactory;
        private readonly IRepositoryNotaFiscal _repositoryNotaFiscal;

        public SalvarNotaFiscalHandler(INotaFiscalFactory notaFiscalfactory, IRepositoryNotaFiscal repositoryNotaFiscal)
        {
            _notaFiscalfactory = notaFiscalfactory;
            _repositoryNotaFiscal = repositoryNotaFiscal;
        }

        public async Task<SalvarNotaFiscalResponse> Handle(SalvarNotaFiscalCommand request, CancellationToken cancellationToken)
        {
            SalvarNotaFiscalResponse retorno = new SalvarNotaFiscalResponse();
            try
            {
                //Valida se ja tem cadastrado com mesmo numero de nota fiscal
                if (await _repositoryNotaFiscal.ObterNotaFiscalPeloId(request.NumeroNotaFiscal) != null)
                {
                    retorno.MensagemErro = $"Numero de nota fiscal {request.NumeroNotaFiscal} já esta cadastrado, escolha outro";
                    return retorno;
                }

                var novaNotaFiscal = _notaFiscalfactory.CriarNotaFiscal
                     (
                     request.NumeroNotaFiscal,
                     request.NomeCliente,
                     request.ValorNotaFiscal,
                     request.DataEmissao);

                retorno.Sucesso = await _repositoryNotaFiscal.CriarNotaFiscal(novaNotaFiscal);
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.MensagemErro = ex.Message;
            }

            return retorno;
        }
    }
}
