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

namespace Road.Inspection.Module.BusinessObjects
{
    [DefaultClassOptions]
    [XafDisplayName("Гүүрэнд гарсан эвдрэл, гэмтэл, согог")]
    
    public class RoadBridgeInjury : RoadItem
    {
        public RoadBridgeInjury(Session session)
            : base(session)
        {
        }
        private RoadInspection _inspectionId;
        [Association]
        public RoadInspection inspectionId { get { return _inspectionId; } set { SetPropertyValue(nameof(inspectionId), ref _inspectionId, value); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}