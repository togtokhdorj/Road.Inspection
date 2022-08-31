using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Models
{
    public class LevelReadiness
	{
        public LevelReadiness()
        {
			startPointN = "";
			startPointE = "";
			endPointN = "";
			endPointE = "";
			subscriberName = "";
			subscriberPositions = "";
			consultantName = "";
			consultantPositions = "";
			roadManager = "";
			roadPositions = "";
			other = "";
		}
		public Guid? id;
		public string startPointN;
		public string startPointE;
		public string endPointN;
		public string endPointE;
		public string subscriberName;
		public string subscriberPositions;
		public string consultantName;
		public string consultantPositions;
		public string roadManager;
		public string roadPositions;
		public string other;
		public int pavementEdgeEvaluation;
		public int dartDam;
		public int bridgeThroat;
		public int markRoadEquipment;
		public int roadConstruction;
		public double kmFrom;
		public double kmTo;
		public double kmTotal;
		public DateTime date;
		public static SqlParameter[] insertSqlParams(LevelReadiness level)
		{
			return new SqlParameter[]
			{
				 new SqlParameter("@id", level.id),
				 new SqlParameter("@startPointN", level.startPointN),
				 new SqlParameter("@startPointE", level.startPointE),
				 new SqlParameter("@endPointN", level.endPointN),
				 new SqlParameter("@endPointE", level.endPointE),
				 new SqlParameter("@subscriberName", level.subscriberName),
				 new SqlParameter("@subscriberPositions", level.subscriberPositions),
				 new SqlParameter("@consultantName", level.consultantName),
				 new SqlParameter("@consultantPositions", level.consultantPositions),
				 new SqlParameter("@roadManager", level.roadManager),
				 new SqlParameter("@roadPositions", level.roadPositions),
				 new SqlParameter("@other", level.other),
				 new SqlParameter("@pavementEdgeEvaluation", level.pavementEdgeEvaluation),
				 new SqlParameter("@dartDam", level.dartDam),
				 new SqlParameter("@bridgeThroat", level.bridgeThroat),
				 new SqlParameter("@markRoadEquipment", level.markRoadEquipment),
				 new SqlParameter("@roadConstruction", level.roadConstruction),
				 new SqlParameter("@kmFrom", level.kmFrom),
				 new SqlParameter("@kmTo", level.kmTo),
				 new SqlParameter("@kmTotal", level.kmTotal),
				 new SqlParameter("@date", level.date),
			};
		}
		public static SqlParameter[] getSqlParams(string id)
		{
			return new SqlParameter[]
			{
				 new SqlParameter("@id", id),
			};
		}
	}
}