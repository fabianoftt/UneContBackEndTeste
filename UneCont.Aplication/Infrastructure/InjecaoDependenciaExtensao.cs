using UneCont.Domain;
using UneCont.Infraestructure.Repository;
using UneCont.Infraestructure.Infrastructure;

namespace UneCont.Aplication.Infrastructure
{
    public static class InjecaoDependenciaExtensao
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryNotaFiscal, RepositoryNotaFiscal>();
            services.AddScoped<INotaFiscalFactory, NotaFiscalFactory>();
            services.AddSingleton<AppDbContext>();
            return services;
        }
    }
}
