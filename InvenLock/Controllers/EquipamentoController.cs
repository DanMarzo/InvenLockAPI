using InvenLock.Data;
using InvenLock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using InvenLock.Models.Enums;

namespace InvenLock.Controllers
{
    /*
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
            if (await _context.EstoqueEquips.AnyAsync(x => x.Id == codigoValidar))
                return true;
            return false;
        }
        public async Task<bool> ValidaUnicidadeNome(string nomeValidar)
        {
            if (await _context.EstoqueEquips.AnyAsync(x => x.NomeEquip.ToLower() == nomeValidar.ToLower()))
                return true;
            return false;
        }
        
        //INICIO CONSULTAS
        [HttpGet("GetAll")]//ConsulatarTodos
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<EstoqueEquip> ListaEquip = await _context.EstoqueEquips.ToListAsync();
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
                EstoqueEquip equipamento = await _context.EstoqueEquips.FirstOrDefaultAsync(x => x.Id == idBusca);
                if (equipamento != null)
                    return Ok(equipamento);
                throw new Exception("Nada foi foi encontrado, verifique o Id");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }/*
        [HttpGet("Disponivel")]
        public async Task<IActionResult> ConsultaDisponiveis()
        {
            try
            {
                EstoqueEquip listaDisponiveis = await _context.EstoqueEquips.Where(x => x.Situacao == StatusEquipEnum.Disponível);
                
                if (listaDisponiveis != null)
                    return Ok(listaDisponiveis);
                else
                    return BadRequest("Nada foi encontrado");
            }
            catch (Exception ex)
            {

            }
        }
        //FIM CONSULTAS

        [HttpPost("NovoEquip")]
        public async Task<IActionResult> AddNovoEquip(EstoqueEquip novo)
        {
            try
            {
                if (await ValidaUnicidade(novo.Id))
                    throw new Exception($"O {novo.Id}, já existe! =)");
                if (await ValidaUnicidadeNome(novo.NomeEquip))
                    throw new Exception($"O {novo.NomeEquip}, já existe! =)");

                novo.DataCompra = DateTime.Now;
                await _context.EstoqueEquips.AddAsync(novo);
                await _context.SaveChangesAsync();

                return Ok($"{novo.Id}:{novo.NomeEquip}, cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    
    }*/
}
