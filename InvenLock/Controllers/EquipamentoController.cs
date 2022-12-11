using InvenLock.Data;
using InvenLock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using InvenLock.Models.Enums;

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
            if (await _context.EstoqueEquipamentos.AnyAsync(x => x.Id == codigoValidar))
                return true;
            return false;
        }
        public async Task<bool> ValidaUnicidadeNome(string nomeValidar)
        {
            if (await _context.EstoqueEquipamentos.AnyAsync(x => x.NomeEquip.ToLower() == nomeValidar.ToLower()))
                return true;
            return false;
        }
        
        //INICIO CONSULTAS
        [HttpGet("GetAll")]//ConsulatarTodos
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<EstoqueEquipamento> ListaEquip = await _context.EstoqueEquipamentos.ToListAsync();
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
        [HttpGet("{id}")]
        public async Task<IActionResult> ConsultaEquipId(int idBusca)
        {
            try
            {
                EstoqueEquipamento equipamento = await _context.EstoqueEquipamentos.FirstOrDefaultAsync(x => x.Id == idBusca);
                if (equipamento != null)
                    return Ok(equipamento);
                throw new Exception("Nada foi foi encontrado, verifique o Id");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("Disponivel")]
        public async Task<IActionResult> ConsultaDisponiveis()
        {
            try
            {
                List<EstoqueEquipamento> listaDisponiveis = new List<EstoqueEquipamento>();
                listaDisponiveis = await _context.EstoqueEquipamentos.Where(x => x.Situacao == StatusEquipEnum.Disponível).ToListAsync();


                if (listaDisponiveis.Count() != 0)
                    return Ok(listaDisponiveis);
                throw new Exception("Nada foi encontrado =)");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //FIM CONSULTAS

        [HttpPost("NovoEquip")]
        public async Task<IActionResult> AddNovoEquip(EstoqueEquipamento novo)
        {
            try
            {
                if (await ValidaUnicidade(novo.Id))
                    throw new Exception($"O {novo.Id}, já existe! =)");
                if (await ValidaUnicidadeNome(novo.NomeEquip))
                    throw new Exception($"O {novo.NomeEquip}, já existe! =)");

                novo.DataCompra = DateTime.Now;
                await _context.EstoqueEquipamentos.AddAsync(novo);
                await _context.SaveChangesAsync();

                return Ok($"{novo.Id}:{novo.NomeEquip}, cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    
    }
}
