using System.Collections.Generic;
using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.DAL
{
    public interface IUserDAO
    {
        Task Create(UserDTO eUser);
        Task Delete(int UserId);
        Task<List<UserDTO>> GetAll();
        Task<List<UserDTO>> GetAll(int UserId);
        Task Update(UserDTO eUser);
    }
}