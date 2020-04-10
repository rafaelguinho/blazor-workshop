using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Forms.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipController : Controller
    {

        private static List<Starship> _starships = new List<Starship>
        {
            new Starship
            {
                Classification = "Exploration",
                Description = "U.S.S. Enterprise NCC-1701 (2271)",
                IsValidatedDesign = true,
                MaximumAccommodation = 600,
                ProductionDate = new DateTime(2293, 1,1)
            }
        };

        public async Task<List<Starship>> Get()
        {
            return _starships;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Starship starship)
        {
            if (!ModelState.IsValid) return BadRequest();

            _starships.Add(starship);

            return Ok(starship);
        }
    }
}
