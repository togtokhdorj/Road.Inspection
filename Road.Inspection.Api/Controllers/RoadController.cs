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
    public class RoadController : ApiController
    {
        RoadService service = new RoadService();
        protected RoadController()
        {
            service = new RoadService();
        }
        [HttpPost]
        [Route("road/inspection/create")]
        [ResponseType(typeof(ResultDto))]
        public HttpResponseMessage CreateRoadInspection(HttpRequestMessage data)
        {
            try
            {
                ResultDto resultDto = new ResultDto();
                string json = data.Content.ReadAsStringAsync().Result;
                RoadDto param = JsonConvert.DeserializeObject<RoadDto>(json);
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
    }
}