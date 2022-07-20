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

        public override RoadDto PopulateRecord(IDataReader reader)
        {
            dto = new RoadDto();
            if (reader["id"] != DBNull.Value)
                dto.id = Guid.Parse(string.Concat(reader["id"]));
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
                dto.kilometr = string.Concat(reader["kilometr"]);
            if (reader["kilometrs"] != DBNull.Value)
                dto.kilometrs = string.Concat(reader["kilometrs"]);
            if (reader["endCoordinates"] != DBNull.Value)
                dto.endCoordinates = string.Concat(reader["endCoordinates"]);
            if (reader["degrees"] != DBNull.Value)
                dto.degrees = string.Concat(reader["degrees"]);
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
            return null;
        }
        public override RoadDto PopulateThirdRecord(IDataReader reader)
        {
            return null;
        }
        public override RoadDto PopulateFourthRecord(IDataReader reader)
        {
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
    }
}