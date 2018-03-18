using System.Collections.Generic;
using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.DAL
{
    public interface ICityDAO
    {
        Task Create(CityDTO eCity);
        Task Delete(int CityId);
        Task<List<CityDTO>> GetAll();
        Task<List<CityDTO>> GetAll(int CityId);
        Task Update(CityDTO eCity);
    }
}