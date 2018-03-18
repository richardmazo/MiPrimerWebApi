using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.BLL
{
    public interface ICityBLO
    {
        IMessageDTO MessageResult { get; }

        Task Create(CityDTO eCity);
        Task Delete(int CityId);
        Task GetAll();
        Task GetAll(int CityId);
        Task Update(CityDTO eCity);
    }
}