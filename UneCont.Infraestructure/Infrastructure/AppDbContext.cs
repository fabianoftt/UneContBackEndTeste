using UneCont.Domain;

namespace UneCont.Infraestructure.Infrastructure
{
    public class AppDbContext 
    {
        public List<NotaFiscal> NotasFiscais { get; set; } = new List<NotaFiscal>();
    }
}
