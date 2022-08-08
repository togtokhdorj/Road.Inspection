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
    public class EvaluationController : ApiController
    {
        EvaluationService service = new EvaluationService();
        protected EvaluationController()
        {
            service = new EvaluationService();
        }

        [HttpGet]
        [Route("road/evaluations")]
        [ResponseType(typeof(List<RoadEvaluation>))]
        public HttpResponseMessage GetRoads()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, ResultDto.success(data: service.Items()));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ResultDto.error(false, ex.Message));
            }
        }
    }
}