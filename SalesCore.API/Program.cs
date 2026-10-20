using Microsoft.EntityFrameworkCore;
using SalesCore.Application.Services;
using SalesCore.Domain.Interfaces;
using SalesCore.Infrastructure.Data;
using SalesCore.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException("A connection string 'DefaultConnection' não foi configurada.");
}

builder.Services.AddDbContext<SalesCoreDbContext>(options => options.UseSqlServer(connectionString));

// Repositórios
builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
builder.Services.AddScoped<IOportunidadeRepository, OportunidadeRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

// Serviços de aplicação
builder.Services.AddScoped<EmpresaService>();
builder.Services.AddScoped<ContatoService>();
builder.Services.AddScoped<OportunidadeService>();
builder.Services.AddScoped<UsuarioService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
