using InvenLock.Data;
using InvenLock.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client;

namespace InvenLock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OcorrenciasController : ControllerBase
    {
        public readonly DataContext _context;
        public OcorrenciasController(DataContext context){ _context = context; }
        // -----> INCLUIR OCORRÊNCIA <-----

        [HttpPost]
        public async Task<IActionResult> NovaOcorrencia(Ocorrencia ocorrencia)
        {
            try 
            {
                bool atualizaSituacao = AtualizaSituacao(ocorrencia);
                bool consultarFinalizado = ConsultarFinalizado(ocorrencia);

                if (!atualizaSituacao)
                    throw new Exception("Não foi encontrado nada :( ");
                if(!consultarFinalizado)
                    throw new Exception("O Id do equipamento está em manutenção, verifique a situação!");

                ocorrencia.DataOcorrencia = DateTime.Now;
                await _context.Ocorrencias.AddAsync(ocorrencia);
                int nLinha = await _context.SaveChangesAsync();

                if(nLinha != 0 )
                    IncluirManut(ocorrencia);
                //Consegui incluir a ocorrencia o equipamento manutenção, porem resta ainda conseguir associar com o Id do manut

                return Ok($"Nova ocorrência de id: {ocorrencia.OcorrenciaId}, criada com sucesso");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public void IncluirManut(Ocorrencia ocorrencia)
        {
            ManutEquip novo = new ManutEquip();
            novo.Desc = ocorrencia.DescOcorrencia;
            novo.DataEntrada = DateTime.Now;
            novo.EstoqueEquipamentoId = ocorrencia.IdEquipamento;
            _context.ManutEquips.Add(novo);
            _context.SaveChanges();
        }
        public bool ConsultarFinalizado(Ocorrencia ocorrencia)
        {
            List<ManutEquip> fim = new List<ManutEquip>();
            fim = _context.ManutEquips.Where(x => x.ManutEquipId == ocorrencia.IdEquipamento).ToList();

            foreach(var i in fim)
            {
                if (i.Situacao != SituacaoManuEnum.Finalizado)
                    return false;
            }
            return true;
        }
        
        public bool AtualizaSituacao(Ocorrencia ocorrencia)
        {
            EstoqueEquipamento estoque = _context.EstoqueEquipamentos.Where(x => x.EstoqueEquipamentoId.Equals(ocorrencia.IdEquipamento)).FirstOrDefault();
            if (estoque == null)
                return false;
            estoque.Situacao = SituacaoEquipEnum.Manutenção;
            _context.Update(estoque);
            _context.SaveChanges();
            return true;
        }
        // -----> LISTAR OCORRÊNCIA <-----

        [HttpGet("Listar")]
        public async Task<IActionResult> ListarOcorrencias()
        {
            try
            {
                List<Ocorrencia> listar = await _context.Ocorrencias.ToListAsync();

                if (listar != null)
                    return Ok(listar);
                throw new Exception("Nada encontrado");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // -----> TROCA SITUAÇÃO OCORRÊNCIA<-----

        [HttpPut("TrocaSituacao")]
        public async Task<IActionResult> NovaSituacao(Ocorrencia ocorrencia)
        {
            try
            {
                Ocorrencia atualizar = await _context.Ocorrencias.FirstOrDefaultAsync(x => x.OcorrenciaId == ocorrencia.OcorrenciaId);
                if (atualizar == null)
                    throw new Exception("Ocorrência não existe ^_^");

                atualizar.Situacao = ocorrencia.Situacao;
                var attach = _context.Attach(atualizar);//aqui deve ir o resultado da pesquisa
                attach.Property(x => x.OcorrenciaId).IsModified = false; 
                attach.Property(x => x.Situacao).IsModified = true;
                await _context.SaveChangesAsync();

                return Ok($"Atualizado com sucesso ^^, nova situacao {ocorrencia.Situacao}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
