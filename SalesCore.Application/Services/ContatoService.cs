using SalesCore.Domain.Entities;
using SalesCore.Domain.Interfaces;

namespace SalesCore.Application.Services;

public sealed class ContatoService
{
    private readonly IContatoRepository _repository;

    public ContatoService(IContatoRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Contato>> ListarAsync(CancellationToken cancellationToken = default)
        => _repository.ListarAsync(cancellationToken);
}
