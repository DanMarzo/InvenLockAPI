using Invelock_API.Data;
using Invelock_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Invelock_API.utility;

namespace Invelock_API.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionarioController : ControllerBase
{
    private readonly Context _context;
    public FuncionarioController(Context context) { _context = context; }

    [HttpPost]
    public async Task<IActionResult> NovoFuncionarioAsync(Funcionario novoF)
    {
        try
        {
            Funcionario verificarF = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Cpf == novoF.Cpf);
            if (verificarF != null)
                throw new Exception("O CPF já esta em uso");

            //int idMax = (int)await _context.Funcionarios.MaxAsync(x => x.FuncionarioId);

            //idMax++;
            
            novoF.Admissao = DateTime.Now;
            //novoF.FuncionarioId = idMax;
            await _context.Funcionarios.AddAsync(novoF);
            int linhas = await _context.SaveChangesAsync();
            
            return Ok(linhas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
