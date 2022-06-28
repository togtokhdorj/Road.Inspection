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
    [XafDisplayName("Үнэлгээний төрөл")]
    public class EvaluationType : BaseObject
    {
        public EvaluationType(Session session)
            : base(session)
        {
        }

        private LevelReadiness _levelReadiness;
        [Association]
        public LevelReadiness levelReadiness { get { return _levelReadiness; } set { SetPropertyValue(nameof(levelReadiness), ref _levelReadiness, value); } }

        private Evaluation _evaluation;
        [VisibleInListView(false), XafDisplayName("Үнэлгээ"), Size(1)]
        public Evaluation evaluation { get { return _evaluation; } set { SetPropertyValue(nameof(evaluation), ref _evaluation, value); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}