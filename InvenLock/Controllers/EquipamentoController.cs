using InvenLock.Data;
using InvenLock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InvenLock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipamentoController : ControllerBase
    {
        public readonly DataContext _context;
        public EquipamentoController(DataContext context)
        {
            _context = context;
        }

        public bool ValidaUnicidade(Equipamento validar)
        {
            Equipamento confirm = _context.Equipamentos.FirstOrDefaultAsync(x => x.Codigo == validar.Codigo);
            if (confirm != null)
                return true;
            else
                return false;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<Equipamento> ListaEquip = await _context.Equipamentos.ToListAsync();
                if(ListaEquip == null)
                    return Ok(ListaEquip);
                else
                    throw new Exception("Nenhum equipamento encontrado, tente adicionar equipamento ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("NovoEquip")]
        public async Task<IActionResult> AddNovoEquipAsync(Equipamento novo)
        {
            try
            {
                if(confirm == null)
                {
                    _context.Equipamentos.Add(novo);
                }
                else
                {
                    throw new Exception("");
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
