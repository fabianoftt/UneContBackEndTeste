namespace UneCont.Aplication.Infrastructure
{
    public static class MapperExtensions
    {
        public static IServiceCollection AddApplicationMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(NotaFiscalProfile).Assembly);

            return services;
        }
    }
}
