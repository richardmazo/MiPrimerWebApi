using Richard.Tutorial.BLL;
using Richard.Tutorial.DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Richard.Tutorial.WebApi.Controllers
{
    public class OrderController : ApiController
    {
        #region Variables
        IOrderBLO OrderBLO;
        #endregion

        #region Constructors
        public OrderController(IOrderBLO _orderBLO)
        {
            OrderBLO = _orderBLO;
        }
        #endregion

        #region Public Methods
        [HttpGet]
        [Route("api/Order/GetAll")]
        public async Task<HttpResponseMessage> GetAll()
        {
            await OrderBLO.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = OrderBLO.MessageResult
                    }
                );
        }

        [HttpGet]
        [Route("api/Order/GetAll")]
        public async Task<HttpResponseMessage> GetAll([FromUri]int OrderId)
        {
            await OrderBLO.GetAll(OrderId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = OrderBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/Order/Create")]
        public async Task<HttpResponseMessage> Create([FromUri]OrdersDTO eOrder)
        {
            await OrderBLO.Create(eOrder);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = OrderBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/Order/Update")]
        public async Task<HttpResponseMessage> Update([FromBody] OrdersDTO eOrder)
        {
            await OrderBLO.Update(eOrder);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = OrderBLO.MessageResult
                    }
                );
        }

        [HttpGet]
        [Route("api/Order/Delete")]
        public async Task<HttpResponseMessage> Delete([FromUri]int OrderId)
        {
            await OrderBLO.Delete(OrderId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = OrderBLO.MessageResult
                    }
                );
        }
        #endregion
    }
}
