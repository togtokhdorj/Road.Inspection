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
    [XafDisplayName("Үнэлгээ")]
    public class RoadEvaluation : BaseObject
    {
        public RoadEvaluation(Session session) : base(session) { }

        private string _code;
        [XafDisplayName("Код"), Size(8)]
        public string code { get { return _code; } set { SetPropertyValue(nameof(code), ref _code, value); } }

        private string _name;
        [XafDisplayName("Нэр"), Size(200)]
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        [DevExpress.Xpo.Aggregated, Association("roadEvaluation-itemss")]
        [XafDisplayName("Кодууд")]
        public XPCollection<RoadEvaluationItem> roadEvaluationItems { get { return GetCollection<RoadEvaluationItem>(nameof(roadEvaluationItems)); } }
    }
}