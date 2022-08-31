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
            if (reader["Oid"] != DBNull.Value)
                dto.id = Guid.Parse(string.Concat(reader["Oid"]));
            if (reader["kmFrom"] != DBNull.Value)
                dto.kmFrom = double.Parse(string.Concat(reader["kmFrom"]));
            if (reader["kmTo"] != DBNull.Value)
                dto.kmTo = double.Parse(string.Concat(reader["kmTo"]));
            if (reader["kmTotal"] != DBNull.Value)
                dto.kmTotal = double.Parse(string.Concat(reader["kmTotal"]));
            if (reader["startPointE"] != DBNull.Value)
                dto.startPointE = string.Concat(reader["startPointE"]);
            if (reader["startPointN"] != DBNull.Value)
                dto.startPointN = string.Concat(reader["startPointN"]);
            if (reader["endPointE"] != DBNull.Value)
                dto.endPointE = string.Concat(reader["endPointE"]);
            if (reader["endPointN"] != DBNull.Value)
                dto.endPointN = string.Concat(reader["endPointN"]);
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
            if (reader["roadPositions"] != DBNull.Value)
                dto.other = string.Concat(reader["other"]);
            if (reader["other"] != DBNull.Value)
                dto.roadPositions = string.Concat(reader["roadPositions"]);
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
            try
            {
                base.ExecuteNonQuery("dbo.sp_level_readiness_create", LevelReadiness.insertSqlParams(param), CommandType.StoredProcedure);
                return ResultDto.success(true, "Амжилттай хадгалагдлаа");
            }
            catch (Exception ex)
            {
                return ResultDto.error(msg: ex.Message);
            }
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