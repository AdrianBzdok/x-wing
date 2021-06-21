using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using x_wingbackend.DataEngine;
using x_wingbackend.DTO;
using x_wingbackend.Models;

namespace x_wingbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ShipsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ShipDto>> GetShips()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<Ship>, IEnumerable<ShipDto>>());
                var mapper = new Mapper(config);

                IEnumerable<ShipDto> xd = mapper.Map<IEnumerable<ShipDto>>(DataAcc.ShipAcc());
                return Ok(xd);
            }
            catch
            {
                return BadRequest();
            }
        }
     /*  [HttpGet("{id}")]
        public ActionResult<Ship> GetShipsId(int id,[FromHeader] string Authorization)
        {   
            if (Authorization == "XD")
            {
                       Ship[] xd = DataAcc.ShipAcc();
                    /   return xd[id];
            } else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] Ship Value, [FromHeader] string Authorization)
        {
            Console.WriteLine("test");
            if (Authorization == "XD")
            {
                Console.WriteLine(Value);
                DataWrite.ShipAdd(Value);
                return Accepted();
            }
            else
            {
                return BadRequest();
            }
        }*/
    }
}