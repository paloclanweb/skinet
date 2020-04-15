using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entitities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly IHouseRepository _repo;

        public HousesController(IHouseRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<House>>> GetHouses()
        {
            var houses = await _repo.GetHouseAsync();

            return Ok(houses);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<House>> GetHouse(int id)
        {
            return await _repo.GetHouseByIdAsync(id);
        }
    }
}