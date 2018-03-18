using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.BLL
{
    public interface ICountryBLO
    {
        IMessageDTO MessageResult { get; }

        Task Create(CountryDTO eCountry);
        Task Delete(int CountryId);
        Task GetAll();
        Task GetAll(int CountryId);
        Task Update(CountryDTO eCountry);
    }
}