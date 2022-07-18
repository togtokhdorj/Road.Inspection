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
    [XafDisplayName("Авто замын хийц хэсгийн эвдрэлийн төрлүүд")]
    public class RoadItem : BaseObject
    {
        public RoadItem(Session session)
            : base(session)
        {
        }

        private string _location;
        [XafDisplayName("Байршил"), Size(20)]
        public string location { get { return _location; } set { SetPropertyValue(nameof(location), ref _location, value); } }

        private string _length;
        [XafDisplayName("Уртраг"), Size(15)]
        public string length { get { return _length; } set { SetPropertyValue(nameof(length), ref _length, value); } }

        private string _latitude;
        [XafDisplayName("Өргөрөг"), Size(15)]
        public string latitude { get { return _latitude; } set { SetPropertyValue(nameof(latitude), ref _latitude, value); } }

        private string _code;
        [XafDisplayName("Код"), Size(20)]
        public string code { get { return _code; } set { SetPropertyValue(nameof(code), ref _code, value); } }

        private string _measure;
        [XafDisplayName("Хэмжих нэгж")]
        [Size(20)]
        public string measure { get { return _measure; } set { SetPropertyValue(nameof(measure), ref _measure, value); } }

        private string _image;
        [XafDisplayName("Зураг"),]
        public string image { get { return _image; } set { SetPropertyValue(nameof(image), ref _image, value); } }

        private RoadInspection _roadInspectionId;
        [Association]
        public RoadInspection roadInspectionId { get { return _roadInspectionId; } set { SetPropertyValue(nameof(roadInspectionId), ref _roadInspectionId, value); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

    }
}