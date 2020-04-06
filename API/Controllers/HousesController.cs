using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entitities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly StoreContext _context;

        public HousesController(StoreContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<List<House>>> GetHouses()
        {
            var houses = await _context.Houses.ToListAsync();

            return Ok(houses);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<House>> GetHouse(int id)
        {
           return await _context.Houses.FindAsync(id);
        }
    }
}