using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SalesCore.Domain.Entities;

namespace SalesCore.Infrastructure.Data;

public partial class SalesCoreDbContext : DbContext
{
    public SalesCoreDbContext(DbContextOptions<SalesCoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atividade> Atividades { get; set; }

    public virtual DbSet<Contato> Contatos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Etapa> Etapas { get; set; }

    public virtual DbSet<Oportunidade> Oportunidades { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atividade>(entity =>
        {
            entity.HasKey(e => e.IdAtividade).HasName("PK__Atividad__E6E8EAE24B4D787B");

            entity.ToTable("Atividade");

            entity.Property(e => e.IdAtividade).HasColumnName("idAtividade");
            entity.Property(e => e.Assunto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("assunto");
            entity.Property(e => e.DataAtividade)
                .HasColumnType("datetime")
                .HasColumnName("dataAtividade");
            entity.Property(e => e.Descricao)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdOportunidade).HasColumnName("idOportunidade");
            entity.Property(e => e.IdUsuarioResponsavel).HasColumnName("idUsuarioResponsavel");
            entity.Property(e => e.Situacao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("situacao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdOportunidadeNavigation).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.IdOportunidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atividade__idOpo__6E01572D");

            entity.HasOne(d => d.IdUsuarioResponsavelNavigation).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.IdUsuarioResponsavel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atividade__idUsu__6EF57B66");
        });

        modelBuilder.Entity<Contato>(entity =>
        {
            entity.HasKey(e => e.IdContato).HasName("PK__Contato__278E896D9FA7EE5F");

            entity.ToTable("Contato");

            entity.Property(e => e.IdContato).HasColumnName("idContato");
            entity.Property(e => e.Ativo)
                .HasDefaultValue(true)
                .HasColumnName("ativo");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefone");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK__Contato__idEmpre__66603565");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PK__Empresa__75D2CED45686F8F4");

            entity.ToTable("Empresa");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Ativo)
                .HasDefaultValue(true)
                .HasColumnName("ativo");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("cnpj");
            entity.Property(e => e.DataCadastro).HasColumnName("dataCadastro");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.NomeFantasia)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nomeFantasia");
            entity.Property(e => e.RazaoSocial)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("razaoSocial");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<Etapa>(entity =>
        {
            entity.HasKey(e => e.IdEtapa).HasName("PK__Etapa__C587A24F1A9E4B08");

            entity.ToTable("Etapa");

            entity.Property(e => e.IdEtapa).HasColumnName("idEtapa");
            entity.Property(e => e.Ativo)
                .HasDefaultValue(true)
                .HasColumnName("ativo");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.PercentualProbabilidade)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("percentualProbabilidade");
        });

        modelBuilder.Entity<Oportunidade>(entity =>
        {
            entity.HasKey(e => e.IdOportunidade).HasName("PK__Oportuni__FA260E2FD7FFD301");

            entity.ToTable("Oportunidade");

            entity.Property(e => e.IdOportunidade).HasColumnName("idOportunidade");
            entity.Property(e => e.DataAbertura).HasColumnName("dataAbertura");
            entity.Property(e => e.DataPrevisaoFechamento).HasColumnName("dataPrevisaoFechamento");
            entity.Property(e => e.Descricao)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdEtapa).HasColumnName("idEtapa");
            entity.Property(e => e.IdUsuarioResponsavel).HasColumnName("idUsuarioResponsavel");
            entity.Property(e => e.Titulo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("titulo");
            entity.Property(e => e.ValorEstimado)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("valorEstimado");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Oportunidades)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Oportunid__idEmp__693CA210");

            entity.HasOne(d => d.IdEtapaNavigation).WithMany(p => p.Oportunidades)
                .HasForeignKey(d => d.IdEtapa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Oportunid__idEta__6A30C649");

            entity.HasOne(d => d.IdUsuarioResponsavelNavigation).WithMany(p => p.Oportunidades)
                .HasForeignKey(d => d.IdUsuarioResponsavel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Oportunid__idUsu__6B24EA82");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A6D1BECAA4");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Ativo)
                .HasDefaultValue(true)
                .HasColumnName("ativo");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
