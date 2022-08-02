using Road.Inspection.Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Repo
{
    public class CrashRepo : BaseRepo<RoadCrash>
    {
        RoadCrash crash;
        List<RoadCrash> dtos;
        RoadCrashCodeItem roadCrashCodeItem;

        public override RoadCrash PopulateRecord(IDataReader reader)
        {
            crash = new RoadCrash();
            if (reader["Oid"] != DBNull.Value)
                crash.id = Guid.Parse(reader["Oid"].ToString());
            if (reader["code"] != DBNull.Value)
                crash.code = string.Concat(reader["code"]);
            if (reader["name"] != DBNull.Value)
                crash.name = string.Concat(reader["name"]);
            dtos.Add(crash);
            return crash;
        }
        public override RoadCrash PopulateSecondRecord(IDataReader reader)
        {
            roadCrashCodeItem = new RoadCrashCodeItem();
            if (reader["crashCodeId"] != DBNull.Value)
                roadCrashCodeItem.crashCodeId = Guid.Parse(reader["crashCodeId"].ToString());
            if (reader["code"] != DBNull.Value)
                roadCrashCodeItem.code = reader["code"].ToString();
            if (reader["name"] != DBNull.Value)
                roadCrashCodeItem.name = reader["name"].ToString();
            if (reader["measure"] != DBNull.Value)
                roadCrashCodeItem.measure = int.Parse(reader["measure"].ToString());

            if (crash.items == null)
                crash.items = new List<RoadCrashCodeItem>();
            if (crash.items != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == roadCrashCodeItem.crashCodeId))
                        dtos.Where(x => x.id == roadCrashCodeItem.crashCodeId).FirstOrDefault().items.Add(roadCrashCodeItem);
                }
                else if (crash != null)
                {
                    crash.items.Add(roadCrashCodeItem);
                }
            }
            return null;
        }
        public override RoadCrash PopulateThirdRecord(IDataReader reader)
        {
            throw new NotImplementedException();
        }
        public override RoadCrash PopulateFourthRecord(IDataReader reader)
        {
            return null;
        }
        public override RoadCrash PopulateFifthRecord(IDataReader reader)
        {
            return null;
        }
        public override RoadCrash PopulateSixthRecord(IDataReader reader)
        {
            return null;
        }
        public override RoadCrash PopulateSeventhRecord(IDataReader reader)
        {
            return null;
        }

        public List<RoadCrash> Items()
        {
            dtos = new List<RoadCrash>();
            base.Get("dbo.sp_road_crashes", RoadCrash.noneParams(), CommandType.StoredProcedure);
            return dtos;
        }
    }
}
