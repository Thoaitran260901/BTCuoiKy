using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace BTCuoiKy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly DataContext _context;
        public GamesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<GameModel>>> GetGameDetail()
        {
            var resutl = _context.Games.ToList();
            return Ok(resutl);
        }
        [HttpPost]
        public async Task<ActionResult<List<GameModel>>> CreateGame(GameModel game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return Ok(game);
        }

    }
}
