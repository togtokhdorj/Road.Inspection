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
    public class RoadCode : BaseObject
    {
        public RoadCode(Session session)
            : base(session)
        {
        }

        private string _name;
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        private string _roadCode;
        public string roadCode { get { return _roadCode; } set { SetPropertyValue(nameof(roadCode), ref _roadCode, value); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}