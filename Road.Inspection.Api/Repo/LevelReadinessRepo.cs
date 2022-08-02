using Road.Inspection.Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Repo
{
    public class LevelReadinessRepo : BaseRepo<LevelReadiness>
    {
        LevelReadiness dto;
        List<LevelReadiness> dtos;

        public override LevelReadiness PopulateRecord(IDataReader reader)
        {
            dto = new LevelReadiness();
            if (reader["id"] != DBNull.Value)
                dto.id = Guid.Parse(string.Concat(reader["id"]));
            if (reader["totalKilometrs"] != DBNull.Value)
                dto.totalKilometrs = int.Parse(string.Concat(reader["totalKilometrs"]));
            if (reader["kilometr"] != DBNull.Value)
                dto.kilometr = int.Parse(string.Concat(reader["kilometr"]));
            if (reader["kilometrs"] != DBNull.Value)
                dto.kilometrs = int.Parse(string.Concat(reader["kilometrs"]));
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
        public override LevelReadiness PopulateSecondRecord(IDataReader reader)
        {
            return null;
        }
        public override LevelReadiness PopulateThirdRecord(IDataReader reader)
        {
            return null;
        }
        public override LevelReadiness PopulateFourthRecord(IDataReader reader)
        {
            return null;
        }
        public override LevelReadiness PopulateFifthRecord(IDataReader reader)
        {
            return null;
        }
        public override LevelReadiness PopulateSixthRecord(IDataReader reader)
        {
            return null;
        }
        public override LevelReadiness PopulateSeventhRecord(IDataReader reader)
        {
            return null;
        }
        public ResultDto Create(LevelReadiness param)
        {
            base.ExecuteNonQuery("dbo.sp_level_readiness_create", LevelReadiness.insertSqlParams(param), CommandType.StoredProcedure);
            return ResultDto.success(true, "Амжилттай хадгалагдлаа");
        }
        public ResultDto Update(LevelReadiness param)
        {
            base.ExecuteNonQuery("dbo.sp_level_readiness_update", LevelReadiness.updateSqlParams(param), CommandType.StoredProcedure);
            return ResultDto.success(true, "Амжилттай хадгалагдлаа");
        }
        public ResultDto GetItems(string id)
        {
            dtos = new List<LevelReadiness>();
            if (id == null)
            {
                base.Get("dbo.sp_level_readiness_get", LevelReadiness.getSqlParams(id), CommandType.StoredProcedure);
                return ResultDto.success(data: dtos);
            }
            else
            {
                base.Get("dbo.sp_level_readiness_get", LevelReadiness.getSqlParams(id), CommandType.StoredProcedure);
                return ResultDto.success(data: dto);
            }
        }
    }
}