using System;
using System.Collections.Generic;

namespace SalesCore.Domain.Entities;

public partial class Oportunidade
{
    public int IdOportunidade { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descricao { get; set; }

    public decimal? ValorEstimado { get; set; }

    public DateOnly? DataAbertura { get; set; }

    public DateOnly? DataPrevisaoFechamento { get; set; }

    public int IdEmpresa { get; set; }

    public int IdEtapa { get; set; }

    public int IdUsuarioResponsavel { get; set; }

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Etapa IdEtapaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioResponsavelNavigation { get; set; } = null!;
}
