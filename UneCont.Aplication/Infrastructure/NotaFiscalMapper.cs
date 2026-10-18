using AutoMapper;
using UneCont.Aplication.Controllers.Consulta;
using UneCont.Domain;

namespace UneCont.Aplication.Infrastructure
{
    public class NotaFiscalProfile : Profile
    {
        public NotaFiscalProfile()
        {
            CreateMap<DtoNotaFiscal, NotaFiscal>();
            CreateMap<NotaFiscal, DtoNotaFiscal>();
        }
    }
}
