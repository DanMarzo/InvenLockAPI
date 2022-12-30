using InvenLock.Data;
using InvenLock.Models;
using InvenLock.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvenLock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionariosController : ControllerBase
    {
        public readonly DataContext _context;
        public FuncionariosController(DataContext context){ _context = context; }

        // ---> ADICIONA FUNCIONARIO <---

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

        // ---> ALTERAR SITUACAO FUNCIONARIO (ATIVO/INATIVO) <---

        [HttpPut]
        public async Task<IActionResult> AtualizaSituacaoFuncAsync(Funcionario novaInfoFunc)
        {
            try
            {
                Funcionario atualizarFunc = await _context.Funcionarios.FirstOrDefaultAsync( x => x.FuncionarioId == novaInfoFunc.FuncionarioId );
                if (atualizarFunc == null)
                    throw new Exception($"Id: {novaInfoFunc.FuncionarioId} inválido");
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

        // ---> AUTENTICAR FUNCIONARIO(ATIVO/INATIVO) <---

        [HttpPost("AutenticarFunc")]
        public async Task<IActionResult> AutenticarFuncionario(Funcionario funcLogin)
        {
            try
            {
                Funcionario autenticar = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Nome.ToLower().Equals(funcLogin.Nome.ToLower()));
                //Funcionario autenticar = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Id == funcLogin.Id);

                if (autenticar == null)
                    throw new Exception("Funcionario não encontrado =(");
                
                //if (!Criptografia.VerificarPasswordHash(funcLogin.PasswordString{Senha Enviada}, autenticar.PasswordHash{Senha do banco}, autenticar.PasswordSalt{Senha do banco}))
                
                if (!Criptografia.VerificarPasswordHash(funcLogin.PasswordString, autenticar.PasswordHash, autenticar.PasswordSalt))
                    throw new Exception("Senha Incorreta =( !");
                return Ok($"Usuario autenticado, bem-vindo {autenticar.Nome}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // ---> CONSULTAR TODOS FUNCIONARIOS <---

        [HttpGet("Listar")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<Funcionario> listaFunc = await _context.Funcionarios.ToListAsync();
                if (listaFunc == null)
                    throw new Exception("Nenhum Funcionário =(!");
                return Ok(listaFunc);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
