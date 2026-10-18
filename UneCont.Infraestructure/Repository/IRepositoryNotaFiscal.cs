using UneCont.Domain;

namespace UneCont.Infraestructure.Repository
{
    public interface IRepositoryNotaFiscal
    {
        Task<bool> CriarNotaFiscal(NotaFiscal notaFiscal);
        Task<List<NotaFiscal>> ObterTodasNotasFiscal();
        Task<NotaFiscal> ObterNotaFiscalPeloId(long numeroNotaFiscal);
        Task<bool> ExcluirNotaFiscal(long numeroNotaFiscal);

    }
}
