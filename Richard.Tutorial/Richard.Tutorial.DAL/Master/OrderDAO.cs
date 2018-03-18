using AutoMapper;
using Richard.Tutorial.DTL;
using Richard.Tutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard.Tutorial.DAL
{
    public class OrderDAO : IOrderDAO
    {
        #region Private variables
        RichardTutorialEntities Context;
        #endregion

        #region Constructors
        public OrderDAO(RichardTutorialEntities _context)
        {
            Context = _context;
        }
        #endregion

        #region Public Methods

        public async Task<List<OrdersDTO>> GetAll()
        {

            return await Task.Run(() =>
            {
                return Mapper.Map<List<OrdersDTO>>(Context.Orders.ToList());
            });
        }

        public async Task<List<OrdersDTO>> GetAll(int OrderId)
        {
            return await Task.Run(() =>
            {
                return Mapper.Map<List<OrdersDTO>>(Context.Orders.Where(x => x.OrderId == OrderId).ToList());
            });
        }

        public async Task Create(OrdersDTO eOrder)
        {
            Orders order = Mapper.Map<Orders>(eOrder);
            Context.Orders.Add(order);
            await Context.SaveChangesAsync();
        }

        public async Task Update(OrdersDTO eOrder)
        {
            Orders order = Mapper.Map<Orders>(eOrder);
            Context.Orders.Attach(order);
            await Context.SaveChangesAsync();
        }

        public async Task Delete(int OrderId)
        {
            Orders order = Context.Orders.FirstOrDefault(x => x.OrderId == OrderId);
            Context.Orders.Remove(order);
            await Context.SaveChangesAsync();
        }
        #endregion
    }
}
