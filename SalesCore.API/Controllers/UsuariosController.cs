using Microsoft.AspNetCore.Mvc;
using SalesCore.Application.Services;
using SalesCore.Domain.Entities;

namespace SalesCore.API.Controllers;

[ApiController]
[Route("api/usuarios")]
public sealed class UsuariosController : ControllerBase
{
    private readonly UsuarioService _service;

    public UsuariosController(UsuarioService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<Usuario>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<Usuario>>> Listar(CancellationToken cancellationToken)
    {
        var itens = await _service.ListarAsync(cancellationToken);
        return Ok(itens);
    }
}
