using SalesCore.Domain.Entities;
using SalesCore.Domain.Interfaces;

namespace SalesCore.Application.Services;

public sealed class EmpresaService
{
    private readonly IEmpresaRepository _repository;

    public EmpresaService(IEmpresaRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Empresa>> ListarAsync(CancellationToken cancellationToken = default)
        => _repository.ListarAsync(cancellationToken);
}
