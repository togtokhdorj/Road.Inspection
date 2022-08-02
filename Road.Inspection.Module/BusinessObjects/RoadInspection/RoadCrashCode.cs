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
    [XafDisplayName("Эвдрэлийн код")]
    public class RoadCrashCode : BaseObject
    {
        public RoadCrashCode(Session session) : base(session) { }

        private string _code;
        [XafDisplayName("Код"), Size(8)]
        public string code { get { return _code; } set { SetPropertyValue(nameof(code), ref _code, value); } }

        private string _name;
        [XafDisplayName("Нэр"), Size(200)]
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        [DevExpress.Xpo.Aggregated, Association("roadCrashCode-items")]
        [XafDisplayName("Кодууд")]
        public XPCollection<RoadCrashCodeItem> items { get { return GetCollection<RoadCrashCodeItem>(nameof(items)); } }
    }
}