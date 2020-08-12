using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Hubcar.Domain.Models;

namespace Hubcar.Domain.HubcarDbContext
{
    public partial class piloto_hubcarContext : DbContext
    {
        public piloto_hubcarContext()
        {
        }

        public piloto_hubcarContext(DbContextOptions<piloto_hubcarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aluguel> Aluguel { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<Carro> Carro { get; set; }
        public virtual DbSet<Carteira> Carteira { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=piloto_hubcar;User Id=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluguel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DataEntrega).HasColumnType("datetime");

                entity.Property(e => e.DataRetirada).HasColumnType("datetime");

                entity.Property(e => e.LocalRetirada)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(e => e.Avaliacao)
                    .WithOne(ad => ad.Aluguel)
                    .HasForeignKey<Avaliacao>(ad => ad.Id);

                entity.HasOne(d => d.Carro)
                    .WithMany(p => p.Aluguel)
                    .HasForeignKey(d => d.Carro.Id)
                    .HasConstraintName("fk_AluguelCarro");
            });

            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Carro>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ano)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorDiaria).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Proprietario)
                    .WithMany(p => p.Carro)
                    .HasForeignKey(d => d.Proprietario.Id)
                    .HasConstraintName("fk_CarroDono");
            });

            modelBuilder.Entity<Carteira>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Usuario)
                    .WithOne(p => p.Carteira)
                    .HasForeignKey<Usuario>(d => d.Id);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("UF")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
