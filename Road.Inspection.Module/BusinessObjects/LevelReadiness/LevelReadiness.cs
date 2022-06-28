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
    [XafDisplayName("Бэлэн байдлын түвшин")]
    public class LevelReadiness : BaseObject
    {
        public LevelReadiness(Session session)
            : base(session)
        {
        }

        private DateTime _date;
        [VisibleInListView(false), XafDisplayName("Үзлэг хийсэн огноо"), Size(10)]
        public DateTime date { get { return _date; } set { SetPropertyValue(nameof(date), ref _date, value); } }

        private string _kilometr;
        [VisibleInListView(false), XafDisplayName("Км-ээс"), Size(5)]
        public string kilometr { get { return _kilometr; } set { SetPropertyValue(nameof(kilometr), ref _kilometr, value); } }

        private string _kilometrs;
        [VisibleInListView(false), XafDisplayName("Км хүртэл"), Size(5)]
        public string kilometrs { get { return _kilometrs; } set { SetPropertyValue(nameof(kilometrs), ref _kilometrs, value); } }

        private string _everyoneKilometrs;
        [VisibleInListView(false), XafDisplayName("Бүгд Км"), Size(5)]
        public string everyoneKilometrs { get { return _everyoneKilometrs; } set { SetPropertyValue(nameof(everyoneKilometrs), ref _everyoneKilometrs, value); } }

        private string _startCoordinateLength;
        [VisibleInListView(false), XafDisplayName("Эхлэл цэгийн солбилцолын уртраг"), Size(15)]
        public string startCoordinateLength { get { return _startCoordinateLength; } set { SetPropertyValue(nameof(startCoordinateLength), ref _startCoordinateLength, value); } }

        private string _startCoordinateLatitude;
        [VisibleInListView(false), XafDisplayName("Эхлэл цэгийн солбилцолын өргөрөг"), Size(15)]
        public string startCoordinateLatitude { get { return _startCoordinateLatitude; } set { SetPropertyValue(nameof(startCoordinateLatitude), ref _startCoordinateLatitude, value); } }

        private string _endCoordinateLength;
        [VisibleInListView(false), XafDisplayName("Төгсгөл цэгийн солбилцолын уртраг"), Size(15)]
        public string endCoordinateLength { get { return _endCoordinateLength; } set { SetPropertyValue(nameof(endCoordinateLength), ref _endCoordinateLength, value); } }

        private string _endCoordinateLatitude;
        [VisibleInListView(false), XafDisplayName("Төгсгөл цэгийн солбилцолын өргөрөг"), Size(15)]
        public string endCoordinateLatitude { get { return _endCoordinateLatitude; } set { SetPropertyValue(nameof(endCoordinateLatitude), ref _endCoordinateLatitude, value); } }

        private string _workChairmanName;
        [VisibleInListView(false), XafDisplayName("Ажлын хэсгийн даргийн нэр"), Size(15)]
        public string workChairmanName { get { return _workChairmanName; } set { SetPropertyValue(nameof(workChairmanName), ref _workChairmanName, value); } }

        private string _memberName;
        [VisibleInListView(false), XafDisplayName("Гишүүдийн нэр"), Size(40)]
        public string memberName { get { return _memberName; } set { SetPropertyValue(nameof(memberName), ref _memberName, value); } }

        private string _roadManagerCampanyName;
        [VisibleInListView(false), XafDisplayName("Зам хариуцагч байгууллагын нэр"), Size(20)]
        public string roadManagerCampanyName { get { return _roadManagerCampanyName; } set { SetPropertyValue(nameof(roadManagerCampanyName), ref _roadManagerCampanyName, value); } }

        private string _position;
        [VisibleInListView(false), XafDisplayName("Албан тушаал"), Size(20)]
        public string position { get { return _position; } set { SetPropertyValue(nameof(position), ref _position, value); } }

        private string _name;
        [VisibleInListView(false), XafDisplayName("Нэр"), Size(20)]
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Үнэлгээ")]
        public XPCollection<EvaluationType> evaluationTypes { get { return GetCollection<EvaluationType>(nameof(evaluationTypes)); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            date = DateTime.Now;
        }
    }
}