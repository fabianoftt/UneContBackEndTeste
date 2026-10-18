using MediatR;
using Microsoft.AspNetCore.Mvc;
using UneCont.Aplication.Controllers.Consulta;
using UneCont.Aplication.Controllers.Excluir;
using UneCont.Aplication.Controllers.Salvar;

namespace UneCont.Aplication.Controllers
{
    [ApiController]
    [Route("api/notas")]
    public class NotaFiscalController : Controller
    {
        private readonly IMediator _mediator;

        public NotaFiscalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost()]
        public async Task<IActionResult> NotaFiscal([FromBody] SalvarNotaFiscalCommand request)
        {
            var retorno = await _mediator.Send(request);

            return retorno.Sucesso ? Ok(retorno) : BadRequest(retorno.MensagemErro);
        }

        [HttpGet]
        public async Task<IActionResult> GetNotasFiscais()
        {
            var listaNotaFiscal = await _mediator.Send(new ConsultaTodasNotasFiscalCommand());

            return Ok(listaNotaFiscal);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirNotaFiscal(long? id)
        {
            var response = await _mediator.Send(new ExcluirNotaFiscalCommand { NumeroNotaFiscal = id.GetValueOrDefault() });

            if (!response.Sucesso)
                return NotFound(new { mensagem = "Nota fiscal não encontrada" });

            return NoContent();
        }
    }
}
