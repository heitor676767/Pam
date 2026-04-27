using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CopaHas.Models;
using CopaHas.Models.Enuns;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CopaHas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadoresExercicioController : ControllerBase
    {/*
         private static List<Jogador> listaJogadores = new List<Jogador>
        {
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
            new Jogador(){Id=21,Nome="Calleri", NumeroCamisa=9, Posicao="Atacante", Status=Models.Enuns.StatusJogador.Titular},
        };

        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            List<Jogador> lista = listaJogadores.FindAll(j => j.Nome.ToLower().Contains(nome.ToLower()));
            if(lista.Count == 0)
                return BadRequest("Jogador Não encontrado");
            else
            { 
                return Ok(lista);
            }
        }

        [HttpGet("GetTitulares")]
        public IActionResult GetTitulares()
        {
            List<Jogador> lista = listaJogadores.FindAll(j => j.Status == StatusJogador.Titular).OrderByDescending(x => x.NumeroCamisa).ToList();
            return Ok(lista);

        }

        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {
            int quantidade = listaJogadores.Count();
            int numCamisa = listaJogadores.Sum(j => j.NumeroCamisa);
            return Ok(new { TotalJogadores = quantidade, SomaCamisas = numCamisa});
        }
         
         [HttpPost("PostValidacao")]
        public IActionResult inserirJogadorMenorcem(Jogador j)
        {
            if (j.NumeroCamisa < 100)
            {
                listaJogadores.Add(j);
                return Ok(listaJogadores);   
            }
            else
            {
                return BadRequest("Numero da camisa muito grande!");
            }
        }

        [HttpPost("PostValidacaoNome")]
        public IActionResult inserirJogadorNome(Jogador j)
        {
            if (j.NumeroCamisa == 1)
            {
                if(j.Posicao == "Goleiro")
                {
                    listaJogadores.Add(j);
                    return Ok(listaJogadores);
                }
                else{
                return BadRequest("Só goleiro tem camisa 1, animal");
                }
            }
            else
            {
                listaJogadores.Add(j);
                return Ok(listaJogadores);
            }
        }

        [HttpGet("GetByStatus/{status}")]
        public IActionResult GetByStatus(int status){
            List<Jogador> lista = listaJogadores.Where(j => (int)j.Status == status).ToList();
            if(lista.Count == 0)
                return BadRequest("Jogador Não encontrado");
            else
            { 
                return Ok(lista);
            }
        }

    */}
}
