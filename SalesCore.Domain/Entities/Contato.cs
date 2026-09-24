using System;
using System.Collections.Generic;

namespace SalesCore.Domain.Entities;

public partial class Contato
{
    public int IdContato { get; set; }

    public string Nome { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public string? Cargo { get; set; }

    public bool? Ativo { get; set; }

    public int? IdEmpresa { get; set; }

    public virtual Empresa? IdEmpresaNavigation { get; set; }
}
