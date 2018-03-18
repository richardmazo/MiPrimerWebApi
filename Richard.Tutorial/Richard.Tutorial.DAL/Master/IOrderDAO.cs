using System.Collections.Generic;
using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.DAL
{
    public interface IOrderDAO
    {
        Task Create(OrdersDTO eOrder);
        Task Delete(int OrderId);
        Task<List<OrdersDTO>> GetAll();
        Task<List<OrdersDTO>> GetAll(int OrderId);
        Task Update(OrdersDTO eOrder);
    }
}