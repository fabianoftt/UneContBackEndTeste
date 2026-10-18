using AutoMapper;
using MediatR;
using UneCont.Infraestructure.Repository;

namespace UneCont.Aplication.Controllers.Consulta
{
    public class ConsultarTodasNotasFiscalHandler : IRequestHandler<ConsultaTodasNotasFiscalCommand, ConsultaTodasNotaFiscalResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryNotaFiscal _repositoryNotaFiscal;

        public ConsultarTodasNotasFiscalHandler(IMapper mapper, IRepositoryNotaFiscal repositoryNotaFiscal)
        {
            _mapper = mapper;
            _repositoryNotaFiscal = repositoryNotaFiscal;
        }

        public async Task<ConsultaTodasNotaFiscalResponse> Handle(ConsultaTodasNotasFiscalCommand request, CancellationToken cancellationToken)
        {
            var response = new ConsultaTodasNotaFiscalResponse();

            var listaNotasFiscal = await _repositoryNotaFiscal.ObterTodasNotasFiscal();
            response.NotaFiscal = _mapper.Map<List<DtoNotaFiscal>>(listaNotasFiscal);
            return response;
        }
    }
}
