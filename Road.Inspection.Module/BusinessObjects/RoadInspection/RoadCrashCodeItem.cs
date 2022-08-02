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
    [XafDisplayName("Эвдрэлийн кодууд")]
    public class RoadCrashCodeItem : BaseObject
    {
        public RoadCrashCodeItem(Session session) : base(session) { }

        private RoadCrashCode _roadCrashCode;
        [Association("roadCrashCode-items")]
        public RoadCrashCode roadCrashCode { get { return _roadCrashCode; } set { SetPropertyValue(nameof(roadCrashCode), ref _roadCrashCode, value); } }

        private string _code;
        [XafDisplayName("Код"), Size(8)]
        public string code { get { return _code; } set { SetPropertyValue(nameof(code), ref _code, value); } }

        private string _name;
        [XafDisplayName("Нэр"), Size(200)]
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        private Measure _measure;
        [XafDisplayName("Хэмжих нэгж")]
        public Measure measure { get { return _measure; } set { SetPropertyValue(nameof(measure), ref _measure, value); } }
    }
}