using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Diagnostics;
using CopaHAs.Models;

namespace CopaHas.Data
{
    public class DataContext: DbContext
    {
    //comentario foda
            public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Jogador> TB_JOGADORES {get;set;}
        public DbSet<Estadio> TB_ESTADIOS {get;set;}
        public DbSet<Selecao> TB_SELECOES {get;set;}
        public DbSet<Tecnico> TB_TECNICOS { get; set; }
        public DbSet<Jogo> TB_JOGOS { get; set; }
        public DbSet<JogoSelecao> TB_JOGO_SELECOES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>().ToTable("TB_JOGADORES");
            modelBuilder.Entity<Estadio>().ToTable("TB_ESTADIOS");
            modelBuilder.Entity<Selecao>().ToTable("TB_SELECOES");
            modelBuilder.Entity<Tecnico>().ToTable("TB_TECNICOs");
            modelBuilder.Entity<Jogo>().ToTable("TB_JOGOS");
            modelBuilder.Entity<JogoSelecao>().ToTable("TB_JOGO_SELECOES");

            modelBuilder.Entity<Selecao>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Pais).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Pais).IsRequired().HasMaxLength(100);
            });
            
            modelBuilder.Entity<Jogador>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Posicao)
                    .HasMaxLength(50);
                entity.HasOne(d => d.SelecaoIdNavegacao)
                    .WithMany(p => p.Jogadores)
                    .HasForeignKey(d => d.SelecaoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            
            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.HasOne(d => d.SelecaoIdNavegacao)
                    .WithOne(p => p.Tecnico)
                    .HasForeignKey<Tecnico>(d => d.SelecaoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

          
            modelBuilder.Entity<Estadio>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(150);
                entity.Property(e => e.Cidade)
                    .HasMaxLength(100);
            });

           
            modelBuilder.Entity<Jogo>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.DataHora)
                    .IsRequired();
                entity.HasOne(d => d.EstadioIdNavegacao)
                    .WithMany(p => p.Jogos)
                    .HasForeignKey(d => d.EstadioId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

         
            modelBuilder.Entity<JogoSelecao>(entity =>
            {
                entity.HasKey(e => new { e.JogoId, e.SelecaoId });
                entity.HasOne(d => d.JogoIdNavegacao)
                    .WithMany(p => p.JogoSelecoes)
                    .HasForeignKey(d => d.JogoId);
                entity.HasOne(d => d.SelecaoIdNavegacao)
                    .WithMany(p => p.JogoSelecoes)
                    .HasForeignKey(d => d.SelecaoId);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

    }
}