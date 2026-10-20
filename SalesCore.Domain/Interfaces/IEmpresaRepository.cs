using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Interfaces;

public interface IEmpresaRepository
{
    Task<IReadOnlyList<Empresa>> ListarAsync(CancellationToken cancellationToken = default);
}
