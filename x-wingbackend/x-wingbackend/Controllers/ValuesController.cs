/*sing System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using x_wingbackend.DataEngine;
using x_wingbackend.Models;

namespace x_wingbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("ships/")]
        public ActionResult<Ship[]> GetShips([FromHeader] string Authorization)
        {
            if (Authorization == "XD")
            {
                Ship[] xd = DataAcc.ShipAcc();
                return xd;
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet("players/")]
        public ActionResult<Player[]> GetPlayers([FromHeader] string Authorization)
        {
            if (Authorization == "XD")
            {
                Player[] xd = DataAcc.PlayerAcc();
                return xd;
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet("ships/{id}")]
        public ActionResult<Ship> GetShipsId(int id,[FromHeader] string Authorization)
        {   
            if (Authorization == "XD")
            {
                        ShipDto[] xd = DataAcc.ShipAcc();
                        return xd[id];
            } else
            {
                return BadRequest();
            }
        }

        // POST api/values
        [HttpPost("players")]
        public ActionResult<object> Post([FromBody] Player Value, [FromHeader] string Authorization, [FromHeader] string[] Command)
        {
            if (Authorization == "XD")
            {
                DataWrite.PlayerAdd(Value);
                return Accepted();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
*/