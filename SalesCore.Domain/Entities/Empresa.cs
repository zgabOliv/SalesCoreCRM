using System;
using System.Collections.Generic;

namespace SalesCore.Domain.Entities;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string RazaoSocial { get; set; } = null!;

    public string? NomeFantasia { get; set; }

    public string? Cnpj { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public DateOnly? DataCadastro { get; set; }

    public bool? Ativo { get; set; }

    public virtual ICollection<Contato> Contatos { get; set; } = new List<Contato>();

    public virtual ICollection<Oportunidade> Oportunidades { get; set; } = new List<Oportunidade>();
}
