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
			startPoint = "";
			endPoint = "";
			endCoordinates = "";
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
			roadBridgeInjury = new List<RoadItemDto>();
			roadDrainge = new List<RoadItemDto>();
			roadEdgeSideSlope = new List<RoadItemDto>();
			roadLane = new List<RoadItemDto>();
			roadServiceFacility = new List<RoadItemDto>();
			smoothnessRoadway = new List<RoadItemDto>();
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
		public string startPoint;
		public string endPoint;
		public int kilometr;
		public int kilometrs;
		public string endCoordinates;
		public int degrees;
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
		public string weather;
		public string date;
		public List<RoadItemDto> roadBridgeInjury;
		public List<RoadItemDto> roadDrainge;
		public List<RoadItemDto> roadEdgeSideSlope;
		public List<RoadItemDto> roadServiceFacility;
		public List<RoadItemDto> smoothnessRoadway;
		public List<RoadItemDto> roadLane;


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
				new SqlParameter("startPoint", level.startPoint),
				new SqlParameter("endPoint", level.endPoint),
				new SqlParameter("kilometr", level.kilometr),
				new SqlParameter("kilometrs", level.kilometrs),
				new SqlParameter("endCoordinates", level.endCoordinates),
				new SqlParameter("degrees", level.degrees),
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
		public string location;
		public string length;
		public string latitude;
		public string code;
		public string measure;
		public string image;
		public int type;
		public static SqlParameter[] insertSqlParams(RoadItemDto param, int type)
        {
			return new SqlParameter[]
			{
					 new SqlParameter("@roadInspectionId", param.inspectionId),
					 new SqlParameter("location", param. location),
					 new SqlParameter("length", param.length),
					 new SqlParameter("latitude", param.latitude),
					 new SqlParameter("code", param.code),
					 new SqlParameter("measure", param.measure),
					 new SqlParameter("image", param.image),
					 new SqlParameter("type", type),
			};
		}
	}
}