using Road.Inspection.Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Repo
{
    public class RoadRepo : BaseRepo<RoadDto>
    {
        RoadDto dto;
        List<RoadDto> dtos;
        RoadItemDto roadBridgeInjuryDto;
        RoadItemDto roadDraingeDto;
        RoadItemDto roadEdgeSideSlopeDto;
        RoadItemDto roadLaneDto;
        RoadItemDto roadServiceFacilityDto;
        RoadItemDto smoothnessRoadwayDto;

        public override RoadDto PopulateRecord(IDataReader reader)
        {
            dto = new RoadDto();
            if (reader["Oid"] != DBNull.Value)
                dto.id = Guid.Parse(string.Concat(reader["Oid"]));
            if (reader["teamLeader"] != DBNull.Value)
                dto.teamLeader = string.Concat(reader["teamLeader"]);
            if (reader["inspectionEngineer"] != DBNull.Value)
                dto.inspectionEngineer = string.Concat(reader["inspectionEngineer"]);
            if (reader["measuringInstrument"] != DBNull.Value)
                dto.measuringInstrument = string.Concat(reader["measuringInstrument"]);
            if (reader["other"] != DBNull.Value)
                dto.other = string.Concat(reader["other"]);
            if (reader["markType"] != DBNull.Value)
                dto.markType = string.Concat(reader["markType"]);
            if (reader["plateNumber"] != DBNull.Value)
                dto.plateNumber = string.Concat(reader["plateNumber"]);
            if (reader["roadNumber"] != DBNull.Value)
                dto.roadNumber = string.Concat(reader["roadNumber"]);
            if (reader["roadDirection"] != DBNull.Value)
                dto.roadDirection = string.Concat(reader["roadDirection"]);
            if (reader["category"] != DBNull.Value)
                dto.category = string.Concat(reader["category"]);
            if (reader["startPoint"] != DBNull.Value)
                dto.startPoint = string.Concat(reader["startPoint"]);
            if (reader["endPoint"] != DBNull.Value)
                dto.endPoint = string.Concat(reader["endPoint"]);
            if (reader["kilometr"] != DBNull.Value)
                dto.kilometr = int.Parse(reader["kilometr"].ToString());
            if (reader["kilometrs"] != DBNull.Value)
                dto.kilometrs = int.Parse(reader["kilometrs"].ToString());
            if (reader["endCoordinates"] != DBNull.Value)
                dto.endCoordinates = string.Concat(reader["endCoordinates"]);
            if (reader["degrees"] != DBNull.Value)
                dto.degrees = int.Parse(reader["degrees"].ToString());
            if (reader["beforeLeftLane"] != DBNull.Value)
                dto.beforeLeftLane = string.Concat(reader["beforeLeftLane"]);
            if (reader["beforeRightLane"] != DBNull.Value)
                dto.beforeRightLane = string.Concat(reader["beforeRightLane"]);
            if (reader["currentLeftLane"] != DBNull.Value)
                dto.currentLeftLane = string.Concat(reader["currentLeftLane"]);
            if (reader["currentRightLane"] != DBNull.Value)
                dto.currentRightLane = string.Concat(reader["currentRightLane"]);
            if (reader["specialNote"] != DBNull.Value)
                dto.specialNote = string.Concat(reader["specialNote"]);
            if (reader["subscriberName"] != DBNull.Value)
                dto.subscriberName = string.Concat(reader["subscriberName"]);
            if (reader["subscriberPositions"] != DBNull.Value)
                dto.subscriberPositions = string.Concat(reader["subscriberPositions"]);
            if (reader["consultantName"] != DBNull.Value)
                dto.consultantName = string.Concat(reader["consultantName"]);
            if (reader["consultantPositions"] != DBNull.Value)
                dto.consultantPositions = string.Concat(reader["consultantPositions"]);
            if (reader["roadManager"] != DBNull.Value)
                dto.roadManager = string.Concat(reader["roadManager"]);
            dtos.Add(dto);
            return dto;
        }
        public override RoadDto PopulateSecondRecord(IDataReader reader)
        {
            roadBridgeInjuryDto = new RoadItemDto();
            if (reader["inspectionId"] != DBNull.Value)
                roadBridgeInjuryDto.inspectionId = Guid.Parse(string.Concat(reader["inspectionId"]));
            if (reader["location"] != DBNull.Value)
                roadBridgeInjuryDto.location = string.Concat(reader["location"]);
            if (reader["length"] != DBNull.Value)
                roadBridgeInjuryDto.length = string.Concat(reader["length"]);
            if (reader["latitude"] != DBNull.Value)
                roadBridgeInjuryDto.latitude = string.Concat(reader["latitude"]);
            if (reader["code"] != DBNull.Value)
                roadBridgeInjuryDto.code = string.Concat(reader["code"]);
            if (reader["measure"] != DBNull.Value)
                roadBridgeInjuryDto.measure = string.Concat(reader["measure"]);
            if (reader["image"] != DBNull.Value)
                roadBridgeInjuryDto.image = string.Concat(reader["image"]);

            if (roadBridgeInjuryDto.inspectionId != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == roadBridgeInjuryDto.inspectionId))
                        dtos.Where(x => x.id == roadBridgeInjuryDto.inspectionId).FirstOrDefault().roadBridgeInjury.Add(roadBridgeInjuryDto);
                }
                else if (dto != null)
                {
                    dto.roadBridgeInjury.Add(roadBridgeInjuryDto);
                }
            }
            return null;
        }
        public override RoadDto PopulateThirdRecord(IDataReader reader)
        {
            roadDraingeDto = new RoadItemDto();
            if (reader["inspectionId"] != DBNull.Value)
                roadDraingeDto.inspectionId = Guid.Parse(string.Concat(reader["inspectionId"]));
            if (reader["location"] != DBNull.Value)
                roadDraingeDto.location = string.Concat(reader["location"]);
            if (reader["length"] != DBNull.Value)
                roadDraingeDto.length = string.Concat(reader["length"]);
            if (reader["latitude"] != DBNull.Value)
                roadDraingeDto.latitude = string.Concat(reader["latitude"]);
            if (reader["code"] != DBNull.Value)
                roadDraingeDto.code = string.Concat(reader["code"]);
            if (reader["measure"] != DBNull.Value)
                roadDraingeDto.measure = string.Concat(reader["measure"]);
            if (reader["image"] != DBNull.Value)
                roadDraingeDto.image = string.Concat(reader["image"]);

            if (roadDraingeDto.inspectionId != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == roadDraingeDto.inspectionId))
                        dtos.Where(x => x.id == roadDraingeDto.inspectionId).FirstOrDefault().roadDrainge.Add(roadDraingeDto);
                }
                else if (dto != null)
                {
                    dto.roadDrainge.Add(roadDraingeDto);
                }
            }
            return null;
        }
        public override RoadDto PopulateFourthRecord(IDataReader reader)
        {
            roadEdgeSideSlopeDto = new RoadItemDto();
            if (reader["inspectionId"] != DBNull.Value)
                roadEdgeSideSlopeDto.inspectionId = Guid.Parse(string.Concat(reader["inspectionId"]));
            if (reader["location"] != DBNull.Value)
                roadEdgeSideSlopeDto.location = string.Concat(reader["location"]);
            if (reader["length"] != DBNull.Value)
                roadEdgeSideSlopeDto.length = string.Concat(reader["length"]);
            if (reader["latitude"] != DBNull.Value)
                roadEdgeSideSlopeDto.latitude = string.Concat(reader["latitude"]);
            if (reader["code"] != DBNull.Value)
                roadEdgeSideSlopeDto.code = string.Concat(reader["code"]);
            if (reader["measure"] != DBNull.Value)
                roadEdgeSideSlopeDto.measure = string.Concat(reader["measure"]);
            if (reader["image"] != DBNull.Value)
                roadEdgeSideSlopeDto.image = string.Concat(reader["image"]);

            if (roadEdgeSideSlopeDto.inspectionId != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == roadEdgeSideSlopeDto.inspectionId))
                        dtos.Where(x => x.id == roadEdgeSideSlopeDto.inspectionId).FirstOrDefault().roadEdgeSideSlope.Add(roadEdgeSideSlopeDto);
                }
                else if (dto != null)
                {
                    dto.roadEdgeSideSlope.Add(roadEdgeSideSlopeDto);
                }
            }
            return null;
        }
        public override RoadDto PopulateFifthRecord(IDataReader reader)
        {
            roadLaneDto = new RoadItemDto();
            if (reader["inspectionId"] != DBNull.Value)
                roadLaneDto.inspectionId = Guid.Parse(string.Concat(reader["inspectionId"]));
            if (reader["location"] != DBNull.Value)
                roadLaneDto.location = string.Concat(reader["location"]);
            if (reader["length"] != DBNull.Value)
                roadLaneDto.length = string.Concat(reader["length"]);
            if (reader["latitude"] != DBNull.Value)
                roadLaneDto.latitude = string.Concat(reader["latitude"]);
            if (reader["code"] != DBNull.Value)
                roadLaneDto.code = string.Concat(reader["code"]);
            if (reader["measure"] != DBNull.Value)
                roadLaneDto.measure = string.Concat(reader["measure"]);
            if (reader["image"] != DBNull.Value)
                roadLaneDto.image = string.Concat(reader["image"]);

            if (roadLaneDto.inspectionId != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == roadLaneDto.inspectionId))
                        dtos.Where(x => x.id == roadLaneDto.inspectionId).FirstOrDefault().roadLane.Add(roadLaneDto);
                }
                else if (dto != null)
                {
                    dto.roadLane.Add(roadLaneDto);
                }
            }
            return null;
        }
        public override RoadDto PopulateSixthRecord(IDataReader reader)
        {
            roadServiceFacilityDto = new RoadItemDto();
            if (reader["inspectionId"] != DBNull.Value)
                roadServiceFacilityDto.inspectionId = Guid.Parse(string.Concat(reader["inspectionId"]));
            if (reader["location"] != DBNull.Value)
                roadServiceFacilityDto.location = string.Concat(reader["location"]);
            if (reader["length"] != DBNull.Value)
                roadServiceFacilityDto.length = string.Concat(reader["length"]);
            if (reader["latitude"] != DBNull.Value)
                roadServiceFacilityDto.latitude = string.Concat(reader["latitude"]);
            if (reader["code"] != DBNull.Value)
                roadServiceFacilityDto.code = string.Concat(reader["code"]);
            if (reader["measure"] != DBNull.Value)
                roadServiceFacilityDto.measure = string.Concat(reader["measure"]);
            if (reader["image"] != DBNull.Value)
                roadServiceFacilityDto.image = string.Concat(reader["image"]);

            if (roadServiceFacilityDto.inspectionId != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == roadServiceFacilityDto.inspectionId))
                        dtos.Where(x => x.id == roadServiceFacilityDto.inspectionId).FirstOrDefault().roadServiceFacility.Add(roadServiceFacilityDto);
                }
                else if (dto != null)
                {
                    dto.roadServiceFacility.Add(roadServiceFacilityDto);
                }
            }
            return null;
        }
        public override RoadDto PopulateSeventhRecord(IDataReader reader)
        {
            smoothnessRoadwayDto = new RoadItemDto();
            if (reader["inspectionId"] != DBNull.Value)
                smoothnessRoadwayDto.inspectionId = Guid.Parse(string.Concat(reader["inspectionId"]));
            if (reader["location"] != DBNull.Value)
                smoothnessRoadwayDto.location = string.Concat(reader["location"]);
            if (reader["length"] != DBNull.Value)
                smoothnessRoadwayDto.length = string.Concat(reader["length"]);
            if (reader["latitude"] != DBNull.Value)
                smoothnessRoadwayDto.latitude = string.Concat(reader["latitude"]);
            if (reader["code"] != DBNull.Value)
                smoothnessRoadwayDto.code = string.Concat(reader["code"]);
            if (reader["measure"] != DBNull.Value)
                smoothnessRoadwayDto.measure = string.Concat(reader["measure"]);
            if (reader["image"] != DBNull.Value)
                smoothnessRoadwayDto.image = string.Concat(reader["image"]);

            if (smoothnessRoadwayDto.inspectionId != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == smoothnessRoadwayDto.inspectionId))
                        dtos.Where(x => x.id == smoothnessRoadwayDto.inspectionId).FirstOrDefault().smoothnessRoadway.Add(smoothnessRoadwayDto);
                }
                else if (dto != null)
                {
                    dto.smoothnessRoadway.Add(smoothnessRoadwayDto);
                }
            }
            return null;
        }
        public ResultDto RoadInpectionCreate(RoadDto param)
        {
            try
            {
                base.ExecuteNonQuery("dbo.sp_road_inspection_create", RoadDto.insertSqlParams(param), CommandType.StoredProcedure);
                return ResultDto.success(true, "Амжилттай хадгалагдлаа");
            }
            catch (Exception ex)
            {
                return ResultDto.error(msg: ex.Message);
            }
        }
        public ResultDto RoadItemCreate(RoadItemDto param, int type)
        {
            base.ExecuteNonQuery("dbo.sp_road_item_create", RoadItemDto.insertSqlParams(param, type), CommandType.StoredProcedure);
            return ResultDto.success(true, "Амжилттай хадгалагдлаа");
        }
        public List<RoadDto> GetRoads()
        {
            dtos = new List<RoadDto>();
            base.Get("dbo.sp_road_inspection_get", RoadDto.noneParams(), CommandType.StoredProcedure);
            return dtos;
        }
    }
}
