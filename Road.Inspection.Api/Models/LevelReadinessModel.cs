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
			startCoordinateLength = "";
			startCoordinateLatitude = "";
			endCoordinateLength = "";
			endCoordinateLatitude = "";
			workChairmanName = "";
			roadManagerCompanyName = "";
			position = "";
			name = "";
		}
		public Guid? id;
		public string startCoordinateLength;
		public string startCoordinateLatitude;
		public string endCoordinateLength;
		public string endCoordinateLatitude;
		public string workChairmanName;
		public string roadManagerCompanyName;
		public string position;
		public string name;
		public int pavementEdgeEvaluation;
		public int dartDam;
		public int bridgeThroat;
		public int markRoadEquipment;
		public int roadConstruction;
		public int kilometr;
		public int kilometrs;
		public int totalKilometrs;
		public DateTime date;
		public static SqlParameter[] insertSqlParams(LevelReadiness level)
		{
			return new SqlParameter[]
			{
				 new SqlParameter("@startCoordinateLength", level.startCoordinateLength),
				 new SqlParameter("@startCoordinateLatitude", level.startCoordinateLatitude),
				 new SqlParameter("@endCoordinateLength", level.endCoordinateLength),
				 new SqlParameter("@endCoordinateLatitude", level.endCoordinateLatitude),
				 new SqlParameter("@workChairmanName", level.workChairmanName),
				 new SqlParameter("@roadManagerCompanyName", level.roadManagerCompanyName),
				 new SqlParameter("@position", level.position),
				 new SqlParameter("@name", level.name),
				 new SqlParameter("@pavementEdgeEvaluation", level.pavementEdgeEvaluation),
				 new SqlParameter("@dartDam", level.dartDam),
				 new SqlParameter("@bridgeThroat", level.bridgeThroat),
				 new SqlParameter("@markRoadEquipment", level.markRoadEquipment),
				 new SqlParameter("@roadConstruction", level.roadConstruction),
				 new SqlParameter("@kilometr", level.kilometr),
				 new SqlParameter("@totalKilometrs", level.totalKilometrs),
				 new SqlParameter("@date", level.date),
			};
		}
		public static SqlParameter[] updateSqlParams(LevelReadiness level)
		{
			return new SqlParameter[]
			{
				 new SqlParameter("@id", level.id),
				 new SqlParameter("@startCoordinateLength", level.startCoordinateLength),
				 new SqlParameter("@startCoordinateLatitude", level.startCoordinateLatitude),
				 new SqlParameter("@endCoordinateLength", level.endCoordinateLength),
				 new SqlParameter("@endCoordinateLatitude", level.endCoordinateLatitude),
				 new SqlParameter("@workChairmanName", level.workChairmanName),
				 new SqlParameter("@roadManagerCompanyName", level.roadManagerCompanyName),
				 new SqlParameter("@position", level.position),
				 new SqlParameter("@name", level.name),
				 new SqlParameter("@pavementEdgeEvaluation", level.pavementEdgeEvaluation),
				 new SqlParameter("@dartDam", level.dartDam),
				 new SqlParameter("@bridgeThroat", level.bridgeThroat),
				 new SqlParameter("@markRoadEquipment", level.markRoadEquipment),
				 new SqlParameter("@roadConstruction", level.roadConstruction),
				 new SqlParameter("@kilometr", level.kilometr),
				 new SqlParameter("@totalKilometrs", level.totalKilometrs),
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