using Road.Inspection.Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Repo
{
    public class EvaluationRepo : BaseRepo<RoadEvaluation>
    {
        RoadEvaluation evaluation;
        List<RoadEvaluation> dtos;
        EvaluationItem evaluationItem;

        public override RoadEvaluation PopulateRecord(IDataReader reader)
        {
            evaluation = new RoadEvaluation();
            if (reader["Oid"] != DBNull.Value)
                evaluation.id = Guid.Parse(reader["Oid"].ToString());
            if (reader["code"] != DBNull.Value)
                evaluation.code = string.Concat(reader["code"]);
            if (reader["name"] != DBNull.Value)
                evaluation.name = string.Concat(reader["name"]);
            dtos.Add(evaluation);
            return evaluation;
        }
        public override RoadEvaluation PopulateSecondRecord(IDataReader reader)
        {
            evaluationItem = new EvaluationItem();
            if (reader["roadEvaluationId"] != DBNull.Value)
                evaluationItem.roadEvaluationId = Guid.Parse(reader["roadEvaluationId"].ToString());
            if (reader["code"] != DBNull.Value)
                evaluationItem.code = reader["code"].ToString();
            if (reader["name"] != DBNull.Value)
                evaluationItem.name = reader["name"].ToString();
            if (reader["evaluation"] != DBNull.Value)
                evaluationItem.evaluation = int.Parse(reader["evaluation"].ToString());

            if (evaluation.items == null)
                evaluation.items = new List<EvaluationItem>();
            if (evaluation.items != null)
            {
                if (dtos != null)
                {
                    if (dtos.Any(x => x.id == evaluationItem.roadEvaluationId))
                        dtos.Where(x => x.id == evaluationItem.roadEvaluationId).FirstOrDefault().items.Add(evaluationItem);
                }
                else if (evaluation != null)
                {
                    evaluation.items.Add(evaluationItem);
                }
            }
            return null;
        }
        public override RoadEvaluation PopulateThirdRecord(IDataReader reader)
        {
            throw new NotImplementedException();
        }
        public override RoadEvaluation PopulateFourthRecord(IDataReader reader)
        {
            return null;
        }
        public override RoadEvaluation PopulateFifthRecord(IDataReader reader)
        {
            return null;
        }
        public override RoadEvaluation PopulateSixthRecord(IDataReader reader)
        {
            return null;
        }
        public override RoadEvaluation PopulateSeventhRecord(IDataReader reader)
        {
            return null;
        }

        public List<RoadEvaluation> Items()
        {
            dtos = new List<RoadEvaluation>();
            base.Get("dbo.sp_road_evaluations", RoadEvaluation.noneParams(), CommandType.StoredProcedure);
            return dtos;
        }
    }
}
