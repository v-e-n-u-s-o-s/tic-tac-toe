using Microsoft.AspNetCore.Mvc;
using tic_tac_toe_API.Models;

namespace tic_tac_toe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        [HttpPost("Create")]
        public void Post([FromBody] string player_1)
        {
            Sessions sessions = new Sessions();
            sessions.CreateSession(Convert.ToInt64(player_1));
        }
        [HttpPut("Join/{player_1}")]
        public void Put(long player_1, [FromBody] string player_2)
        {
            Sessions sessions = new Sessions();
            sessions.JoinSession(player_1, Convert.ToInt64(player_2));
        }
    }
}
