using System;
using System.Collections.Generic;

namespace SalesCore.Domain.Entities;

public partial class Etapa
{
    public int IdEtapa { get; set; }

    public string Nome { get; set; } = null!;

    public int? Ordem { get; set; }

    public decimal? PercentualProbabilidade { get; set; }

    public bool? Ativo { get; set; }

    public virtual ICollection<Oportunidade> Oportunidades { get; set; } = new List<Oportunidade>();
}
