using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CopaHas.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Jogador> TB_JOGADORES {get;set;}
        public DbSet<Estadio> TB_ESTADIOS {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>().HasData
            (
                new Jogador(){Id=1,Nome="Hugo Souza", NumeroCamisa=1, Posicao="Goleiro", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=2,Nome="Cássio", NumeroCamisa=12, Posicao="Goleiro", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=3,Nome="Rafael", NumeroCamisa=23, Posicao="Goleiro", Status=Models.Enuns.StatusJogador.Reserva},
                new Jogador(){Id=4,Nome="Fábio", NumeroCamisa=1, Posicao="Goleiro", Status=Models.Enuns.StatusJogador.Titular},

                new Jogador(){Id=5,Nome="Fagner", NumeroCamisa=23, Posicao="Lateral Direito", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=6,Nome="Samuel Xavier", NumeroCamisa=2, Posicao="Lateral Direito", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=7,Nome="Ayrton Lucas", NumeroCamisa=6, Posicao="Lateral Esquerdo", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=8,Nome="Reinaldo", NumeroCamisa=6, Posicao="Lateral Esquerdo", Status=Models.Enuns.StatusJogador.Titular},

                new Jogador(){Id=9,Nome="Geromel", NumeroCamisa=3, Posicao="Zagueiro", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=10,Nome="Kannemann", NumeroCamisa=4, Posicao="Zagueiro", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=11,Nome="Nino", NumeroCamisa=33, Posicao="Zagueiro", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=12,Nome="Fabrício Bruno", NumeroCamisa=15, Posicao="Zagueiro", Status=Models.Enuns.StatusJogador.Titular},

                new Jogador(){Id=13,Nome="André", NumeroCamisa=7, Posicao="Volante", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=14,Nome="João Gomes", NumeroCamisa=35, Posicao="Volante", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=15,Nome="Thiago Maia", NumeroCamisa=8, Posicao="Volante", Status=Models.Enuns.StatusJogador.Reserva},

                new Jogador(){Id=16,Nome="Arrascaeta", NumeroCamisa=14, Posicao="Meia", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=17,Nome="Ganso", NumeroCamisa=10, Posicao="Meia", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=18,Nome="Cristiano Ronaldo", NumeroCamisa=7, Posicao="Atacante", Status=Models.Enuns.StatusJogador.Reserva},

                new Jogador(){Id=19,Nome="Pedro", NumeroCamisa=9, Posicao="Atacante", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=20,Nome="Gabriel Barbosa", NumeroCamisa=10, Posicao="Atacante", Status=Models.Enuns.StatusJogador.Titular},
                new Jogador(){Id=21,Nome="Calleri", NumeroCamisa=9, Posicao="Atacante", Status=Models.Enuns.StatusJogador.Titular}
            );
        
            modelBuilder.Entity<Estadio>().HasData
            (
                new Estadio(){Id=1, Nome="Neo Quimica Arena", Cidade="Sao Paulo", Capacidade=50000},
                new Estadio(){Id=2, Nome="Morumbis", Cidade="Sao Paulo", Capacidade=80000},
                new Estadio(){Id=3, Nome="Chiqueiro", Cidade="Sao Paulo", Capacidade=40000},
                new Estadio(){Id=4, Nome="Siri boy Arena", Cidade="Sao Paulo", Capacidade=67676},
                new Estadio(){Id=5, Nome="Parque dos principes", Cidade="Paris", Capacidade=80000},
                new Estadio(){Id=6, Nome="Fonte Nova", Cidade="Salvador", Capacidade=40000},
                new Estadio(){Id=7, Nome="Aura Stadium", Cidade="Sao Paulo", Capacidade=77777}
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

    }
}