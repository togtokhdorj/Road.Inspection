using Road.Inspection.Api.Models;
using Road.Inspection.Api.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Service
{
    public class LevelReadinessService
    {
        private LevelReadinessRepo repo;

        public LevelReadinessService()
        {
            repo = new LevelReadinessRepo();
        }
        public ResultDto Create(LevelReadiness level)
        {
            return repo.Create(level);
        }
        public ResultDto Update(LevelReadiness level)
        {
            return repo.Update(level);
        }
        public ResultDto GetItems(string id)
        {
            return repo.GetItems(id);
        }
    }
}