using System;
using System.Collections.Generic;

namespace SalesCore.Domain.Entities;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string? Email { get; set; }

    public string? Cargo { get; set; }

    public bool? Ativo { get; set; }

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    public virtual ICollection<Oportunidade> Oportunidades { get; set; } = new List<Oportunidade>();
}
