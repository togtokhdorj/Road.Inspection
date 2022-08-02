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
    public class CrashController : ApiController
    {
        CrashService service = new CrashService();
        protected CrashController()
        {
            service = new CrashService();
        }

        [HttpGet]
        [Route("road/crashes")]
        [ResponseType(typeof(List<RoadCrash>))]
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