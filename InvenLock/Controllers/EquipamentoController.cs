using InvenLock.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
