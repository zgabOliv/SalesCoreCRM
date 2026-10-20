using System;
using System.Collections.Generic;

namespace SalesCore.Domain.Entities;

public partial class Atividade
{
    public int IdAtividade { get; set; }

    public string? Tipo { get; set; }

    public string? Assunto { get; set; }

    public string? Descricao { get; set; }

    public DateTime? DataAtividade { get; set; }

    public string? Situacao { get; set; }

    public int IdOportunidade { get; set; }

    public int IdUsuarioResponsavel { get; set; }

    public virtual Oportunidade IdOportunidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioResponsavelNavigation { get; set; } = null!;
}
