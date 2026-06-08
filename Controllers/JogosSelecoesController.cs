using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHas.Data;
using CopaHas.Models;
using CopaHAs.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CopaHas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogosSelecoesController : ControllerBase
{
    private readonly DataContext _context;

    public JogosSelecoesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet("{jogoId}/{selecaoId}")]
    public async Task<IActionResult> GetSingle(int jogoId, int selecaoId)
    {
        try
        {
            JogoSelecao jogoSelecao = await _context.TB_JOGO_SELECOES
                .FirstOrDefaultAsync(e => e.JogoId == jogoId && e.SelecaoId == selecaoId);
            return Ok(jogoSelecao);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + " - " + ex.InnerException);
        }
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> Get()
    {
        try
        {
            List<JogoSelecao> lista = await _context.TB_JOGO_SELECOES.ToListAsync();
            return Ok(lista);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + " - " + ex.InnerException);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Add(JogoSelecao jogoSelecao)
    {
        try
        {
            await _context.TB_JOGO_SELECOES.AddAsync(jogoSelecao);
            await _context.SaveChangesAsync();
            return Ok(jogoSelecao);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + " - " + ex.InnerException);
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update(JogoSelecao jogoSelecao)
    {
        try
        {
            _context.TB_JOGO_SELECOES.Update(jogoSelecao);
            await _context.SaveChangesAsync();
            return Ok(jogoSelecao);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + " - " + ex.InnerException);
        }
    }

    [HttpDelete("{jogoId}/{selecaoId}")]
    public async Task<IActionResult> Delete(int jogoId, int selecaoId)
    {
        try
        {
            JogoSelecao jogoSelecao = await _context.TB_JOGO_SELECOES
                .FirstOrDefaultAsync(e => e.JogoId == jogoId && e.SelecaoId == selecaoId);
            _context.TB_JOGO_SELECOES.Remove(jogoSelecao);
            await _context.SaveChangesAsync();
            return Ok(jogoSelecao);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + " - " + ex.InnerException);
        }
    }
    }
}