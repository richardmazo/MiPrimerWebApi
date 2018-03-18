using Richard.Tutorial.BLL;
using Richard.Tutorial.DTL;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Richard.Tutorial.WebApi.Controllers
{
    public class CityController : ApiController
    {

        #region Variables
        ICityBLO CityBLO;
        #endregion

        #region Constructors
        public CityController(ICityBLO _cityBLO)
        {
            CityBLO = _cityBLO;
        }
        #endregion

        #region Public Methods
        [HttpGet]
        [Route("api/City/GetAll")]
        public async Task<HttpResponseMessage> GetAll()
        {
            await CityBLO.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CityBLO.MessageResult
                    }                
                );
        }

        [HttpGet]
        [Route("api/City/GetAll")]
        public async Task<HttpResponseMessage> GetAll([FromUri]int CityId)
        {
            await CityBLO.GetAll(CityId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CityBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/City/Create")]
        public async Task<HttpResponseMessage> Create([FromUri]CityDTO eCity)
        {
            await CityBLO.Create(eCity);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CityBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/City/Update")]
        public async Task<HttpResponseMessage> Update([FromBody] CityDTO eCity)
        {
            await CityBLO.Update(eCity);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CityBLO.MessageResult
                    }
                );
        }

        [HttpGet]
        [Route("api/City/Delete")]
        public async Task<HttpResponseMessage> Delete([FromUri]int CityId)
        {
            await CityBLO.Delete(CityId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CityBLO.MessageResult
                    }
                );
        }
        #endregion
    }
}
