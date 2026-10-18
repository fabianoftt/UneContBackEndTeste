namespace UneCont.Aplication.Infrastructure
{
    public class UneContErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public UneContErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";

                var result = new
                {
                    status = 500,
                    mensagem = "Ocorreu um erro inesperado.",
                    detalhe = ex.Message
                };

                //serivoc de log http

                await context.Response.WriteAsJsonAsync(result);
            }
        }
    }
}
