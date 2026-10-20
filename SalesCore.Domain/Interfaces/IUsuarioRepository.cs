using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Interfaces;

public interface IUsuarioRepository
{
    Task<IReadOnlyList<Usuario>> ListarAsync(CancellationToken cancellationToken = default);
}
