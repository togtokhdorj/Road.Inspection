using Newtonsoft.Json;
using Road.Inspection.Api.Models;
using Road.Inspection.Api.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Road.Inspection.Api.Controllers
{
    public class ReadinessController : ApiController
    {
        LevelReadinessService service = new LevelReadinessService();
        protected ReadinessController()
        {
            service = new LevelReadinessService();
        }
        [HttpPost]
        [Route("level/readiness/create")]
        [ResponseType(typeof(ResultDto))]
        public HttpResponseMessage CreateLevelReadiness(HttpRequestMessage data)
        {
            try
            {
                ResultDto resultDto = new ResultDto();
                string json = data.Content.ReadAsStringAsync().Result;
                LevelReadiness param = JsonConvert.DeserializeObject<LevelReadiness>(json);
                if (param == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, ResultDto.error(false, "Өгөгдөл хоосон илгээж байна."));
                else
                {
                    resultDto = service.Create(param);
                    return Request.CreateResponse(HttpStatusCode.OK, resultDto);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ResultDto.error(false, ex.Message));
            }
        }
        [HttpGet]
        [Route("level/readiness")]
        [ResponseType(typeof(List<LevelReadiness>))]
        public HttpResponseMessage GetItems(string id = null)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, service.GetItems(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ResultDto.error(false, ex.Message));
            }
        }
    }
}