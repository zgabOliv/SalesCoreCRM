using Microsoft.AspNetCore.Mvc;
using SalesCore.Application.Services;
using SalesCore.Domain.Entities;

namespace SalesCore.API.Controllers;

[ApiController]
[Route("api/contatos")]
public sealed class ContatosController : ControllerBase
{
    private readonly ContatoService _service;

    public ContatosController(ContatoService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<Contato>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<Contato>>> Listar(CancellationToken cancellationToken)
    {
        var itens = await _service.ListarAsync(cancellationToken);
        return Ok(itens);
    }
}
