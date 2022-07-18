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
        public ResultDto Create(LevelReadinessDto level)
        {
            return repo.Create(level);
        }
        public ResultDto Update(LevelReadinessDto level)
        {
            return repo.Update(level);
        }
        public List<LevelReadinessDto> GetItems(string id)
        {
            return repo.GetItems(id);
        }
    }
}