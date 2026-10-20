using Microsoft.EntityFrameworkCore;
using SalesCore.Domain.Entities;
using SalesCore.Domain.Interfaces;
using SalesCore.Infrastructure.Data;

namespace SalesCore.Infrastructure.Repositories;

public sealed class EmpresaRepository : IEmpresaRepository
{
    private readonly SalesCoreDbContext _context;

    public EmpresaRepository(SalesCoreDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Empresa>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Empresas
            .AsNoTracking()
            .OrderBy(e => e.RazaoSocial)
            .ToListAsync(cancellationToken);
    }
}
