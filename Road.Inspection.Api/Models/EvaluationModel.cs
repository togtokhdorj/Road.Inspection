using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Models
{
	public class RoadEvaluation
	{
		public RoadEvaluation()
		{
			items = new List<EvaluationItem>();
		}
		public Guid? id;
		public string code;
		public string name;
		public int evaluation;
		public List<EvaluationItem> items;

		public static SqlParameter[] noneParams()
		{
			return new SqlParameter[]
			{
			};
		}
	}
	public class EvaluationItem
	{
		public EvaluationItem()
		{
		}
		public Guid? roadEvaluationId;
		public string code;
		public string name;
		public int evaluation;

		public static SqlParameter[] noneParams()
		{
			return new SqlParameter[]
			{
			};
		}
	}
}