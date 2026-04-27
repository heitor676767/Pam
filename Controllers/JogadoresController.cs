using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHas.Data;
using CopaHas.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CopaHas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadoresController : ControllerBase
    {
        private readonly DataContext _context;
        public JogadoresController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Jogador j = await _context.TB_JOGADORES.FirstOrDefaultAsync(pBusca => pBusca.Id == id);
                
                return Ok(j);
            }

            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + "." + ex.InnerException);    
            }
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Jogador> lista = await _context.TB_JOGADORES.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

        /*private static List<Jogador> listaJogadores = new List<Jogador>
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
        [HttpGet("GetAll")]
        public IActionResult obterJogadores()
        {
            List<Jogador> lista = listaJogadores;
            return Ok(lista);
        }
        
        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            return Ok(listaJogadores[0]);
        }
        
        [HttpPost]
        public IActionResult inserirJogador(Jogador j)
        {
            listaJogadores.Add(j);
            return Ok(listaJogadores);
        }

        [HttpGet("GetOrdenado")]
        public IActionResult GetOrdem()
        {
            List<Jogador> listaFinal = listaJogadores.OrderBy(j => j.Nome).ToList();
            return Ok(listaFinal);            
        }   

        [HttpPut("AtualizarJogador")]
        public IActionResult Atualizar(Jogador j)
        {
            Jogador jEncontrado = listaJogadores.Find(jBusca => jBusca.Id == j.Id);

            if(jEncontrado == null)
                return BadRequest("Jogador nao encontrado");

            jEncontrado.Nome = j.Nome;
            jEncontrado.NumeroCamisa = j.NumeroCamisa;
            jEncontrado.Posicao = j.Posicao;

            return Ok(listaJogadores);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            listaJogadores.RemoveAll(j => j.Id == id);
            return Ok(listaJogadores);
        }

        [HttpGet("GetByNomeAproximado/{nome}")]
        public IActionResult GetByNomeAproximado(string nome)
        {
            List<Jogador> lista = listaJogadores.FindAll(j => j.Nome.ToLower().Contains(nome.ToLower()));
            return Ok(lista);
        }

     */   
    }
    }
