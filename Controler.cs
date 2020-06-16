using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

        namespace Kolokwium2.Controllers
    {
        [Microsoft.AspNetCore.Components.Route("api/championships")]
        public class ChampionshipsController : ControllerBase
        {

            private readonly IGameDbService _service;

            public ChampionshipsController(IGameDbService service)
            {
                _service = service;
            }

            [HttpGet]
            [Route("{id}/teams")]
            public IActionResult GetAllTeams(int id)
            {
                var result = _service.GetAllTeams(id);
                return Ok(result);
            }
        }
    }

