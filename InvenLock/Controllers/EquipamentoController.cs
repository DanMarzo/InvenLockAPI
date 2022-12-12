using InvenLock.Data;
using InvenLock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using InvenLock.Models.Enums;
using System.Xml;

namespace InvenLock.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class EquipamentoController : ControllerBase
    {
        public readonly DataContext _context;
        public EquipamentoController(DataContext context){ _context = context; }
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
        
        // -- INICIO -- CONSULTAS
        [HttpGet("GetAll")]//ConsulatarTodos
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<EstoqueEquipamento> ListaEquip = await _context.EstoqueEquipamentos.ToListAsync();
                if(ListaEquip != null)
                    return Ok(ListaEquip);
                throw new Exception("Nenhum equipamento encontrado, tente adicionar equipamento ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{idBusca}")] // Ele nao retorna nada pedir ajuda =(
        public async Task<IActionResult> GetUnicoAsync(int idBusca)
        {
            try
            {
                EstoqueEquipamento equipamento = new EstoqueEquipamento();
                equipamento = await _context.EstoqueEquipamentos.FirstOrDefaultAsync(x => x.Id == idBusca);
                if (equipamento == null)
                   throw new Exception("Nada foi foi encontrado, verifique o Id");
                return Ok(equipamento);
            }
            catch (Exception ex)
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
        // -- FIM -- CONSULTAS
        // -- INICIO -- INSERÇÃO DE DADOS
        [HttpPost("NovoEquip")]
        public async Task<IActionResult> AddNovoEquip(EstoqueEquipamento novo)
        {
            try
            {
                if (await ValidaUnicidade(novo.Id))
                    throw new Exception($"O {novo.Id}, já existe! =)");
                if (await ValidaUnicidadeNome(novo.NomeEquip))
                    throw new Exception($"O {novo.NomeEquip}, já existe! =)");
                if(novo.Situacao != StatusEquipEnum.Disponível)
                    throw new Exception($"Todos os equipamentos adicionados devem começar como novo, {novo.Situacao} verifique e logo atualize");

                novo.DataCompra = DateTime.Now;
                await _context.EstoqueEquipamentos.AddAsync(novo);
                await _context.SaveChangesAsync();
                return Ok($"{novo.Id}:{novo.NomeEquip}, cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // -- FIM -- INSERÇÃO DE DADOS
        // -- INICIO -- Atualiza dados
        // ---------> (INICIO) REFERENTE A INCLUSÃO DE UM FORMULARIO <--------- 
        [HttpPost("IncluirForms")] //Funciona =)   
        public async Task<IActionResult> AddFormaAsync(FormEmprestimo form)
        {
            try
            {
                bool funcAtivo = FuncionarioAtivo(form);
                bool livre = ConsultaDisponibilidade(form);
                bool atualizado = AtualizarDadosEquipamentos(form);

                if (funcAtivo != true)
                    throw new Exception("Funcionario não existe!");
                
                if (livre != true)
                    throw new Exception("Equipamento indisponivel");
                
                if (atualizado != true)
                    throw new Exception("Erro ao salvar");

                form.Emissao = DateTime.Now;
                await _context.FormEmprestimos.AddAsync(form);
                await _context.SaveChangesAsync();
                return Ok("Formulario cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public bool FuncionarioAtivo(FormEmprestimo funcAtivo)
        {
            Funcionario consulta = _context.Funcionarios.FirstOrDefault(x => x.Id == funcAtivo.FuncionarioId);
            if (consulta != null)
                return true;
            return false;
        }
        public bool ConsultaDisponibilidade(FormEmprestimo situacao)
        {
            EstoqueEquipamento consulta = _context.EstoqueEquipamentos.FirstOrDefault(x => x.Id == situacao.EstoqueEquipamentoId);
            if (consulta == null)
                return false;
            if (consulta.Situacao != StatusEquipEnum.Disponível)
                return false;
            return true;
        }
        public bool AtualizarDadosEquipamentos(FormEmprestimo atualiza)
        {
            EstoqueEquipamento atualizando = _context.EstoqueEquipamentos.FirstOrDefault(x => x.Id == atualiza.EstoqueEquipamentoId);
            if (atualizando == null)
                return false;
            atualizando.Situacao = StatusEquipEnum.Emprestado;
            _context.EstoqueEquipamentos.Update(atualizando);
            _context.SaveChanges();
            return true;
        }
        // ---------> (FIM) REFERENTE A INCLUSÃO DE UM FORMULARIO <--------- 
    }
}
