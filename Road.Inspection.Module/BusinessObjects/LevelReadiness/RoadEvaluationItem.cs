using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Road.Inspection.Module.BusinessObjects.LevelReadiness
{
    [DefaultClassOptions]
    [XafDisplayName("Үнэлгээний код")]
    public class RoadEvaluationItem : BaseObject
    {
        public RoadEvaluationItem(Session session) : base(session) { }

        private RoadEvaluation _roadEvaluation;
        [Association("roadEvaluation-itemss")]
        public RoadEvaluation roadEvaluation { get { return _roadEvaluation; } set { SetPropertyValue(nameof(roadEvaluation), ref _roadEvaluation, value); } }

        private string _code;
        [XafDisplayName("Код"), Size(8)]
        public string code { get { return _code; } set { SetPropertyValue(nameof(code), ref _code, value); } }

        private string _name;
        [XafDisplayName("Нэр"), Size(200)]
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        private Evaluation _evaluation;
        [XafDisplayName("Үнэлгээ")]
        public Evaluation evaluation { get { return _evaluation; } set { SetPropertyValue(nameof(evaluation), ref _evaluation, value); } }
    }
}