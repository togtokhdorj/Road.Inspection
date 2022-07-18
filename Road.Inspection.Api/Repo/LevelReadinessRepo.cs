using Road.Inspection.Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Repo
{
    public class LevelReadinessRepo : BaseRepo<LevelReadinessDto>
    {
        LevelReadinessDto dto;
        List<LevelReadinessDto> dtos;

        public override LevelReadinessDto PopulateRecord(IDataReader reader)
        {
            dto = new LevelReadinessDto();
            if (reader["id"] != DBNull.Value)
                dto.id = Guid.Parse(string.Concat(reader["id"]));
            if (reader["totalKilometrs"] != DBNull.Value)
                dto.totalKilometrs = int.Parse(string.Concat(reader["totalKilometrs"]));
            if (reader["kilometr"] != DBNull.Value)
                dto.kilometr = int.Parse(string.Concat(reader["kilometr"]));
            if (reader["startCoordinateLength"] != DBNull.Value)
                dto.startCoordinateLength = string.Concat(reader["startCoordinateLength"]);
            if (reader["startCoordinateLatitude"] != DBNull.Value)
                dto.startCoordinateLatitude = string.Concat(reader["startCoordinateLatitude"]);
            if (reader["endCoordinateLength"] != DBNull.Value)
                dto.endCoordinateLength = string.Concat(reader["endCoordinateLength"]);
            if (reader["endCoordinateLatitude"] != DBNull.Value)
                dto.endCoordinateLatitude = string.Concat(reader["endCoordinateLatitude"]);
            if (reader["workChairmanName"] != DBNull.Value)
                dto.workChairmanName = string.Concat(reader["workChairmanName"]);
            if (reader["position"] != DBNull.Value)
                dto.position = string.Concat(reader["position"]);
            if (reader["name"] != DBNull.Value)
                dto.name = string.Concat(reader["name"]);
            if (reader["pavementEdgeEvaluation"] != DBNull.Value)
                dto.pavementEdgeEvaluation = int.Parse(string.Concat(reader["pavementEdgeEvaluation"]));
            if (reader["dartDam"] != DBNull.Value)
                dto.dartDam = int.Parse(string.Concat(reader["dartDam"]));
            if (reader["bridgeThroat"] != DBNull.Value)
                dto.bridgeThroat = int.Parse(string.Concat(reader["bridgeThroat"]));
            if (reader["markRoadEquipment"] != DBNull.Value)
                dto.markRoadEquipment = int.Parse(string.Concat(reader["markRoadEquipment"]));
            if (reader["roadConstruction"] != DBNull.Value)
                dto.roadConstruction = int.Parse(string.Concat(reader["roadConstruction"]));
            if (reader["date"] != DBNull.Value)
                dto.date = DateTime.Parse(string.Concat(reader["date"]));
            dtos.Add(dto);
            return dto;
        }
        public override LevelReadinessDto PopulateSecondRecord(IDataReader reader)
        {
            return null;
        }
        public override LevelReadinessDto PopulateThirdRecord(IDataReader reader)
        {
            return null;
        }
        public override LevelReadinessDto PopulateFourthRecord(IDataReader reader)
        {
            return null;
        }
        public ResultDto Create(LevelReadinessDto param)
        {
            base.ExecuteNonQuery("dbo.sp_level_readiness_create", LevelReadinessDto.insertSqlParams(param), CommandType.StoredProcedure);
            return ResultDto.success(true,"Амжилттай хадгалагдлаа");
        }
        public ResultDto Update(LevelReadinessDto param)
        {
            base.ExecuteNonQuery("dbo.sp_level_readiness_update", LevelReadinessDto.updateSqlParams(param), CommandType.StoredProcedure);
            return ResultDto.success(true, "Амжилттай хадгалагдлаа");
        }
        public List<LevelReadinessDto> GetItems(string id)
        {
            dtos = new List<LevelReadinessDto>();
            base.Get("dbo.sp_level_readiness_get", LevelReadinessDto.getSqlParams(id), CommandType.StoredProcedure);
            return dtos;
        }
    }
}