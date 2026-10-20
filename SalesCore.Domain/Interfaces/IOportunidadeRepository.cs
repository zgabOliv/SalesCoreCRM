using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Interfaces;

public interface IOportunidadeRepository
{
    Task<IReadOnlyList<Oportunidade>> ListarAsync(CancellationToken cancellationToken = default);
}
