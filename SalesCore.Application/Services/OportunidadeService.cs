using SalesCore.Domain.Entities;
using SalesCore.Domain.Interfaces;

namespace SalesCore.Application.Services;

public sealed class OportunidadeService
{
    private readonly IOportunidadeRepository _repository;

    public OportunidadeService(IOportunidadeRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Oportunidade>> ListarAsync(CancellationToken cancellationToken = default)
        => _repository.ListarAsync(cancellationToken);
}
