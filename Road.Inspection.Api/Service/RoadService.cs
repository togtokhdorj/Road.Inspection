using Road.Inspection.Api.Models;
using Road.Inspection.Api.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Service
{
    public class RoadService
    {
        private RoadRepo repo;

        public RoadService()
        {
            repo = new RoadRepo();
        }
        public ResultDto Create(RoadDto param)
        {
            try
            {
                ResultDto result = new ResultDto();
                //--RoadBridgeInjury = 1
                //--RoadDrainge = 2
                //--RoadEdgeSideSlope = 3
                //--RoadBridgeInjury = 4
                //--SmoothnessRoadway = 5
                var _inspectionId = param.id;
                result = repo.RoadInpectionCreate(param);
                if (result.status)
                {
                    foreach (var item in param.roadBridgeInjuries)
                    {
                        item.inspectionId = _inspectionId;
                        repo.RoadItemCreate(item, 1);
                    }
                    foreach (var item in param.roadDrainges)
                    {
                        item.inspectionId = _inspectionId;
                        repo.RoadItemCreate(item, 2);
                    }
                    foreach (var item in param.roadEdgeSideSlopes)
                    {
                        item.inspectionId = _inspectionId;
                        repo.RoadItemCreate(item, 3);
                    }
                    foreach (var item in param.roadServiceFacilities)
                    {
                        item.inspectionId = _inspectionId;
                        repo.RoadItemCreate(item, 4);
                    }
                    foreach (var item in param.smoothnessRoadways)
                    {
                        item.inspectionId = _inspectionId;
                        repo.RoadItemCreate(item, 5);
                    }
                    foreach (var item in param.roadLanes)
                    {
                        item.inspectionId = _inspectionId;
                        repo.RoadItemCreate(item, 6);
                    }
                    return result = new ResultDto { status = true, message = "Амжилттай хадгаллаа" };
                }
                else
                    return ResultDto.error(msg: result.message);
            }
            catch (Exception ex)
            {
                return ResultDto.error(msg: ex.Message);
            }
        }
        public ResultDto CreateRoadItem(RoadItemDto param)
        {
            return repo.RoadItemCreate(param, param.type);
        }
        public List<RoadDto> GetRoads()
        {
            return repo.GetRoads();
        }
    }
}



