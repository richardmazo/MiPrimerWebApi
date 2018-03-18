using System.Threading.Tasks;
using Richard.Tutorial.DTL;

namespace Richard.Tutorial.BLL
{
    public interface IOrderBLO
    {
        IMessageDTO MessageResult { get; }

        Task Create(OrdersDTO eOrder);
        Task Delete(int OrderId);
        Task GetAll();
        Task GetAll(int OrderId);
        Task Update(OrdersDTO eOrder);
    }
}