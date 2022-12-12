using InvenLock.Data;
using InvenLock.Models;
using InvenLock.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvenLock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public readonly DataContext _context;
        public FuncionarioController(DataContext context){ _context = context; }
        
        [HttpPost]
        public async Task<IActionResult> NovoFuncionario(Funcionario funcionario)
        {
            try
            {
                Funcionario verificar = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Cpf == funcionario.Cpf);
                if (verificar != null)
                    throw new Exception("O CPF já esta em uso, por favor verificar a lista de funcionarios");
                
                Criptografia.CriarPasswordHash(funcionario.PasswordString, out byte[] hash, out byte[] salt);
                funcionario.PasswordSalt = salt;
                funcionario.PasswordHash = hash;

                funcionario.Admissao = DateTime.Now;

                await _context.Funcionarios.AddAsync(funcionario);
                await _context.SaveChangesAsync();
                return Ok($"Funcionario {funcionario.Nome} salvo com sucesso!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> AtualizaSituacaoFuncAsync(Funcionario novaInfoFunc)
        {
            try
            {
                Funcionario atualizarFunc = await _context.Funcionarios.FirstOrDefaultAsync( x => x.Id == novaInfoFunc.Id );
                if (atualizarFunc == null)
                    throw new Exception($"Id: {novaInfoFunc.Id} inválido");
                atualizarFunc.Situacao = novaInfoFunc.Situacao;
                _context.Funcionarios.Update(atualizarFunc);
                int linhas = await _context.SaveChangesAsync();
                return Ok($"{linhas} alteradas");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
