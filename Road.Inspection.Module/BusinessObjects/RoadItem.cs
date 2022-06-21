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
    public class RoadItem : BaseObject
    {
        public RoadItem(Session session)
            : base(session)
        {
        }

        private string _location;
        [XafDisplayName("Байршил")]
        public string location { get { return _location; } set { SetPropertyValue(nameof(location), ref _location, value); } }

        private string _length;
        [VisibleInListView(false), Size(15)]
        [XafDisplayName("Уртраг")]
        public string length { get { return _length; } set { SetPropertyValue(nameof(length), ref _length, value); } }

        private int _latitude;
        [Size(15)]
        public int latitude { get { return _latitude; } set { SetPropertyValue(nameof(latitude), ref _latitude, value); } }

        private string _roadCode;
        public string roadCode { get { return _roadCode; } set { SetPropertyValue(nameof(roadCode), ref _roadCode, value); } }


        private string _measure;
        public string measure { get { return _measure; } set { SetPropertyValue(nameof(measure), ref _measure, value); } }

        private string _name;
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        private FileData _image;
        [VisibleInListView(false)]
        public FileData image { get { return _image; } set { SetPropertyValue(nameof(image), ref _image, value); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}