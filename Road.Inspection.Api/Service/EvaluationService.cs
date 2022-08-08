using Road.Inspection.Api.Models;
using Road.Inspection.Api.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Service
{
    public class EvaluationService
    {
        private EvaluationRepo repo;

        public EvaluationService()
        {
            repo = new EvaluationRepo();
        }
        public List<RoadEvaluation> Items()
        {
            return repo.Items();
        }
    }
}