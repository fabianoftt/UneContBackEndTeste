using UneCont.Domain;
using UneCont.Infraestructure.Infrastructure;

namespace UneCont.Infraestructure.Repository
{
    public class RepositoryNotaFiscal : IRepositoryNotaFiscal
    {
        private readonly AppDbContext _context;

        public RepositoryNotaFiscal(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CriarNotaFiscal(NotaFiscal notaFiscal)
        {
            _context.NotasFiscais.Add(notaFiscal);
            return true;
        }

        public async Task<bool> ExcluirNotaFiscal(long numeroNotaFiscal)
        {
            var removido = _context.NotasFiscais.RemoveAll(x => x.NumeroNotaFiscal == numeroNotaFiscal);
            return removido > 0;
        }

        public async Task<NotaFiscal> ObterNotaFiscalPeloId(long numeroNotaFiscal)
        {
            return _context.NotasFiscais.FirstOrDefault(c => c.NumeroNotaFiscal == numeroNotaFiscal);
        }

        public async Task<List<NotaFiscal>> ObterTodasNotasFiscal()
        {
            return _context.NotasFiscais.OrderBy(c => c.DataCadastroNotaFiscal).ToList();
        }
    }
}
