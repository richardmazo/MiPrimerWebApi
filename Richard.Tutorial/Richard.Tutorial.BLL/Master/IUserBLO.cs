using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.BLL
{
    public interface IUserBLO
    {
        IMessageDTO MessageResult { get; }

        Task Create(UserDTO eUser);
        Task Delete(int UserId);
        Task GetAll();
        Task GetAll(int UserId);
        Task Update(UserDTO eUser);
    }
}