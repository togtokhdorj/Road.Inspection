using Road.Inspection.Api.Models;
using Road.Inspection.Api.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Service
{
    public class CrashService
    {
        private CrashRepo repo;

        public CrashService()
        {
            repo = new CrashRepo();
        }
        public List<RoadCrash> Items()
        {
            return repo.Items();
        }
    }
}