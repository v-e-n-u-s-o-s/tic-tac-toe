using tic_tac_toe_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace tic_tac_toe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpGet("Get/{player_1}")]
        public string Get(long player_1)
        {
            Sessions sessions = new Sessions();
            return sessions.GetData(player_1);
        }
        [HttpPut("Set/{player_x}")]
        public void Put(long player_x, [FromBody] string data)
        {
            Sessions sessions = new Sessions();
            sessions.SetData(player_x, data);
        }
    }
}
