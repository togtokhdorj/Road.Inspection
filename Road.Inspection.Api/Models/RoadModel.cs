using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Models
{
    public class RoadDto
	{
		public RoadDto()
        {
			inspectionEngineer = "";
			measuringInstrument = "";
			other = "";
			markType = "";
			plateNumber = "";
			roadNumber = "";
			roadDirection = "";
			category = "";
			startPointN = "";
			startPointE = "";
			endPointN = "";
			endPointE = "";
			beforeLaneDate = "";
			beforeLeftLane = "";
			beforeRightLane = "";
			currentLeftLane = "";
			currentRightLane = "";
			specialNote = "";
			subscriberName = "";
			subscriberPositions = "";
			consultantName = "";
			consultantPositions = "";
			roadManager = "";
			roadPositions = "";
			roadBridgeInjuries = new List<RoadItemDto>();
			roadDrainges = new List<RoadItemDto>();
			roadEdgeSideSlopes = new List<RoadItemDto>();
			roadLanes = new List<RoadItemDto>();
			roadServiceFacilities = new List<RoadItemDto>();
			smoothnessRoadways = new List<RoadItemDto>();
			date = "";
		}
		public Guid id;
		public string teamLeader;
		public string inspectionEngineer;
		public string measuringInstrument;
		public string other;
		public string markType; 
		public string plateNumber;
		public string roadNumber;
		public string roadDirection;
		public string category;
		public string startPointN;
		public string startPointE;
		public string endPointN;
		public string endPointE;
		public string kilometr;
		public string kilometrs;
		public string degrees;
		public string beforeLaneDate;
		public string beforeLeftLane;
		public string beforeRightLane;
		public string currentLeftLane;
		public string currentRightLane;
		public string specialNote;
		public string subscriberName;
		public string subscriberPositions;
		public string consultantName;
		public string consultantPositions;
		public string roadManager;
		public string roadPositions;
		public string companyName;
		public string weather;
		public string date;
		public List<RoadItemDto> roadBridgeInjuries;
		public List<RoadItemDto> roadDrainges;
		public List<RoadItemDto> roadEdgeSideSlopes;
		public List<RoadItemDto> roadServiceFacilities;
		public List<RoadItemDto> smoothnessRoadways;
		public List<RoadItemDto> roadLanes;


		public static SqlParameter[] insertSqlParams(RoadDto level)
		{
			return new SqlParameter[]
			{
				new SqlParameter("id", level.id),
				new SqlParameter("teamLeader", level.teamLeader),
				new SqlParameter("inspectionEngineer", level.inspectionEngineer),
				new SqlParameter("measuringInstrument", level.measuringInstrument),
				new SqlParameter("other", level.other),
				new SqlParameter("markType", level.markType),
				new SqlParameter("plateNumber", level.plateNumber),
				new SqlParameter("roadNumber", level.roadNumber),
				new SqlParameter("roadDirection", level.roadDirection),
				new SqlParameter("category", level.category),
				new SqlParameter("startPointN", level.startPointN),
				new SqlParameter("startPointE", level.startPointE),
				new SqlParameter("endPointN", level.endPointN),
				new SqlParameter("endPointE", level.endPointE),
				new SqlParameter("kilometr", level.kilometr),
				new SqlParameter("kilometrs", level.kilometrs),
				new SqlParameter("degrees", level.degrees),
				new SqlParameter("beforeLaneDate", level.beforeLaneDate),
				new SqlParameter("beforeLeftLane", level.beforeLeftLane),
				new SqlParameter("beforeRightLane", level.beforeRightLane),
				new SqlParameter("currentLeftLane", level.currentLeftLane),
				new SqlParameter("currentRightLane", level.currentRightLane),
				new SqlParameter("specialNote", level.specialNote),
				new SqlParameter("subscriberName", level.subscriberName),
				new SqlParameter("subscriberPositions", level.subscriberPositions),
				new SqlParameter("consultantName", level.consultantName),
				new SqlParameter("consultantPositions", level.consultantPositions),
				new SqlParameter("roadManager", level.roadManager),
				new SqlParameter("roadPositions", level.roadPositions),
				new SqlParameter("companyName", level.companyName),
				new SqlParameter("weather", level.weather),
				new SqlParameter("date", level.date),
			};
		}
		public static SqlParameter[] noneParams()
        {
			return new SqlParameter[]
			{
			};
		}
	}
	public class RoadItemDto
    {
		public RoadItemDto()
        {
		}
		public Guid inspectionId;
		public Guid id;
		public string location;
		public string length;
		public string latitude;
		public string code;
		public string qty;
		public string measure;
		public string image1;
		public string image2;
		public string image3;
		public int type;
		public static SqlParameter[] insertSqlParams(RoadItemDto param, int type)
        {
			return new SqlParameter[]
			{
					 new SqlParameter("@id", param.id),
					 new SqlParameter("@roadInspectionId", param.inspectionId),
					 new SqlParameter("location", param. location),
					 new SqlParameter("length", param.length),
					 new SqlParameter("latitude", param.latitude),
					 new SqlParameter("code", param.code),
					 new SqlParameter("qty", param.qty),
					 new SqlParameter("measure", param.measure),
					 new SqlParameter("image1", param.image1),
					 new SqlParameter("image2", param.image2),
					 new SqlParameter("image3", param.image3),
					 new SqlParameter("type", type),
			};
		}
	}
}