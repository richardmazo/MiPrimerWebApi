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
    public class CountryController : ApiController
    {
        #region Variables
        ICountryBLO CountryBLO;
        #endregion

        #region Contructors
        public CountryController(ICountryBLO _countryBLO)
        {
            CountryBLO = _countryBLO;
        }
        #endregion

        #region Public Methods
        [HttpGet]
        [Route("api/Country/GetAll")]
        public async Task<HttpResponseMessage> GetAll()
        {
            await CountryBLO.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CountryBLO.MessageResult
                    }
                );
        }

        [HttpGet]
        [Route("api/Country/GetAll")]
        public async Task<HttpResponseMessage> GetAll([FromUri]int CountryId)
        {
            await CountryBLO.GetAll(CountryId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CountryBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/Country/Create")]
        public async Task<HttpResponseMessage> Create([FromUri]CountryDTO eCountry)
        {
            await CountryBLO.Create(eCountry);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CountryBLO.MessageResult
                    }
                );
        }

        [HttpPost]
        [Route("api/Country/Update")]
        public async Task<HttpResponseMessage> Update([FromBody] CountryDTO eCountry)
        {
            await CountryBLO.Update(eCountry);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CountryBLO.MessageResult
                    }
                );
        }

        [HttpGet]
        [Route("api/Country/Delete")]
        public async Task<HttpResponseMessage> Delete([FromUri]int CountryId)
        {
            await CountryBLO.Delete(CountryId);

            return Request.CreateResponse(HttpStatusCode.OK,
                    new
                    {
                        Result = CountryBLO.MessageResult
                    }
                );
        }
        #endregion

    }
}
