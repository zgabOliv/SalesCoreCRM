using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Interfaces;

public interface IContatoRepository
{
    Task<IReadOnlyList<Contato>> ListarAsync(CancellationToken cancellationToken = default);
}
