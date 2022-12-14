using InvenLock.Data;
using InvenLock.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace InvenLock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OcorrenciasController : ControllerBase
    {
        public readonly DataContext _context;
        public OcorrenciasController(DataContext context){ _context = context; }

        [HttpPost]
        public async Task<IActionResult> NovaOcorrencia(Ocorrencia ocorrencia)
        {
            try 
            {
                /*List<ManutEquip> consultLista = new List<ManutEquip>();
                consultLista = await _context.ManutEquips.Where(x => x.Id == ocorrencia.IdEquipamento).ToListAsync();

                if(consultLista.Count() != 0)
                {
                    foreach (var i in consultLista)
                    {
                        if (i.Situacao != SituacaoManuEnum.Finalizado) 
                            throw new Exception("O mesmo está em manutenção");
                    }*/

                EstoqueEquipamento equip = await _context.EstoqueEquipamentos.FirstOrDefaultAsync(x => x.Id == ocorrencia.IdEquipamento);
                    if (equip == null) 
                        throw new Exception("O equipamento nao existe! =)");

                    ManutEquip novo = new();
                    int pesq = await _context.ManutEquips.MaxAsync(m => m.Id);
                    
                    pesq++;

                    novo.Id = pesq;
                    novo.Desc = ocorrencia.DescOcorrencia;
                    novo.DataEntrada = DateTime.Now;
                    novo.EstoqueEquipamentoId = equip.Id;

                    equip.Situacao = SituacaoEquipEnum.Manutenção;

                    ocorrencia.DataOcorrencia = DateTime.Now;

                    _context.EstoqueEquipamentos.Update(equip);
                    await _context.ManutEquips.AddAsync(novo);
                    await _context.Ocorrencias.AddAsync(ocorrencia);
                    await _context.SaveChangesAsync();

                    return Ok(ocorrencia);
                //}
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
