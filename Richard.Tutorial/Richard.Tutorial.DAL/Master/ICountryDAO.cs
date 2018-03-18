using System.Collections.Generic;
using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.DAL
{
    public interface ICountryDAO
    {
        Task Create(CountryDTO eCountry);
        Task Delete(int CountryId);
        Task<List<CountryDTO>> GetAll();
        Task<List<CountryDTO>> GetAll(int CountryId);
        Task Update(CountryDTO eCountry);
    }
}