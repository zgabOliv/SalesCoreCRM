using Microsoft.EntityFrameworkCore;
using SalesCore.Domain.Entities;
using SalesCore.Domain.Interfaces;
using SalesCore.Infrastructure.Data;

namespace SalesCore.Infrastructure.Repositories;

public sealed class OportunidadeRepository : IOportunidadeRepository
{
    private readonly SalesCoreDbContext _context;

    public OportunidadeRepository(SalesCoreDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Oportunidade>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Oportunidades
            .AsNoTracking()
            .OrderBy(e => e.Titulo)
            .ToListAsync(cancellationToken);
    }
}
