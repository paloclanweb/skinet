using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entitities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class HouseRepository : IHouseRepository
    {
        private readonly StoreContext _context;
        public HouseRepository(StoreContext context)
        {
            _context = context;

        }
        public async Task<IReadOnlyList<House>> GetHouseAsync()
        {
            return await _context.Houses.ToListAsync();
        }

        public async Task<House> GetHouseByIdAsync(int id)
        {
            return await _context.Houses.FindAsync(id);
        }
    }
}