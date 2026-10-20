using Microsoft.AspNetCore.Mvc;
using SalesCore.Application.Services;
using SalesCore.Domain.Entities;

namespace SalesCore.API.Controllers;

[ApiController]
[Route("api/empresas")]
public sealed class EmpresasController : ControllerBase
{
    private readonly EmpresaService _service;

    public EmpresasController(EmpresaService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<Empresa>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<Empresa>>> Listar(CancellationToken cancellationToken)
    {
        var itens = await _service.ListarAsync(cancellationToken);
        return Ok(itens);
    }
}
