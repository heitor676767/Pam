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
    public class TecnicosController : ControllerBase
    {
        private readonly DataContext _context;

        public TecnicosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Tecnico tecnico = await _context.TB_TECNICOS.FirstOrDefaultAsync(eBusca => eBusca.Id == id);
                return Ok(tecnico);
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
                List<Tecnico> lista = await _context.TB_TECNICOS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(Tecnico tecnico)
        {
            try
            {
                await _context.TB_TECNICOS.AddAsync(tecnico);
                await _context.SaveChangesAsync();
                return Ok(tecnico);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Tecnico tecnico)
        {
            try
            {
                _context.TB_TECNICOS.Update(tecnico);
                await _context.SaveChangesAsync();
                return Ok(tecnico);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Tecnico tecnico = await _context.TB_TECNICOS
                    .FirstOrDefaultAsync(e => e.Id == id);
                _context.TB_TECNICOS.Remove(tecnico);
                await _context.SaveChangesAsync();
                return Ok(tecnico);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
    }
}