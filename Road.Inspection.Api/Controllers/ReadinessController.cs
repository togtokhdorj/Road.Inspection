using Newtonsoft.Json;
using Road.Inspection.Api.Models;
using Road.Inspection.Api.Service;
using System;
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
                LevelReadinessDto param = JsonConvert.DeserializeObject<LevelReadinessDto>(json);
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
        [HttpPost]
        [Route("level/readiness/update")]
        [ResponseType(typeof(ResultDto))]
        public HttpResponseMessage UpdateLevelReadiness(HttpRequestMessage data)
        {
            try
            {
                ResultDto resultDto = new ResultDto();
                string json = data.Content.ReadAsStringAsync().Result;
                LevelReadinessDto param = JsonConvert.DeserializeObject<LevelReadinessDto>(json);
                if (param == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, ResultDto.error(false, "Өгөгдөл хоосон илгээж байна."));
                else
                {
                    resultDto = service.Update(param);
                    return Request.CreateResponse(HttpStatusCode.OK, resultDto);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ResultDto.error(false, ex.Message));
            }
        }
        [HttpGet]
        [Route("level/readiness/get")]
        [ResponseType(typeof(ResultDto))]
        public HttpResponseMessage GetItems(string id)
        {
            try
            {
                ResultDto resultDto = new ResultDto();
                resultDto.data = service.GetItems(id);
                return Request.CreateResponse(HttpStatusCode.OK, resultDto);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ResultDto.error(false, ex.Message));
            }
        }
    }
}