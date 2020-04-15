using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entitities;

namespace Core.Interfaces
{
    public interface IHouseRepository
    {
        Task<House> GetHouseByIdAsync(int id) ;
        Task<IReadOnlyList<House>> GetHouseAsync() ;
    }
}