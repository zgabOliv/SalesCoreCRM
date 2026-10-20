using SalesCore.Domain.Entities;
using SalesCore.Domain.Interfaces;

namespace SalesCore.Application.Services;

public sealed class UsuarioService
{
    private readonly IUsuarioRepository _repository;

    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Usuario>> ListarAsync(CancellationToken cancellationToken = default)
        => _repository.ListarAsync(cancellationToken);
}
