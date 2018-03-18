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
    public class UserController : ApiController
    {
        #region Variables
        IUserBLO UserBLO;
        #endregion

        #region Constructors
        public UserController(IUserBLO _userBLO)
        {
            UserBLO = _userBLO;
        }
        #endregion

        #region Public Methods
        [HttpGet]
        [Route("api/User/GetAll")]
        public async Task<HttpResponseMessage> GetAll()
        {
            await UserBLO.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = UserBLO.MessageResult
                    }
                );
        }

        [HttpGet]
        [Route("api/User/GetAll")]
        public async Task<HttpResponseMessage> GetAll([FromUri]int UserId)
        {
            await UserBLO.GetAll(UserId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = UserBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/User/Create")]
        public async Task<HttpResponseMessage> Create([FromUri]UserDTO eUser)
        {
            await UserBLO.Create(eUser);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = UserBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/User/Update")]
        public async Task<HttpResponseMessage> Update([FromUri] UserDTO eUser)
        {
            await UserBLO.Update(eUser);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = UserBLO.MessageResult
                    }
                );
        }

        [HttpGet]
        [Route("api/User/Delete")]
        public async Task<HttpResponseMessage> Delete([FromUri]int UserId)
        {
            await UserBLO.Delete(UserId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = UserBLO.MessageResult
                    }
                );
        }
        #endregion
    }
}
