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

        public async Task<bool> ValidaUnicidade(int codigoValidar)
        {
            if (await _context.Equipamentos.AnyAsync(x => x.Id == codigoValidar))
                return true;
            return false;
        }
        public async Task<bool> ValidaUnicidadeNome(string nomeValidar)
        {
            if (await _context.Equipamentos.AnyAsync(x => x.NomeEquip.ToLower() == nomeValidar.ToLower()))
                return true;
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
        public async Task<IActionResult> AddNovoEquip(Equipamento novo)
        {
            try
            {
                if (await ValidaUnicidade(novo.Id))
                    throw new Exception($"O {novo.Id}, já existe! =)");
                if (await ValidaUnicidadeNome(novo.NomeEquip))
                    throw new Exception($"O {novo.NomeEquip}, já existe! =)");

                novo.DataCompra = DateTime.Now;
                await _context.Equipamentos.AddAsync(novo);
                await _context.SaveChangesAsync();

                return Ok($"{novo.Id}:{novo.NomeEquip}, cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
    }
}
