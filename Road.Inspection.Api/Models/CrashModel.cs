using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Models
{
	public class RoadCrash
	{
		public RoadCrash()
		{
			items = new List<RoadCrashCodeItem>();
		}
		public Guid? id;
		public string code;
		public string name;
		public List<RoadCrashCodeItem> items;

		public static SqlParameter[] noneParams()
		{
			return new SqlParameter[]
			{
			};
		}
	}

	public class RoadCrashCodeItem
	{
		public RoadCrashCodeItem()
		{
		}
		public Guid? crashCodeId;
		public string code;
		public string name;
		public int measure;

		public static SqlParameter[] noneParams()
		{
			return new SqlParameter[]
			{
			};
		}
	}
}