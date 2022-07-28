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
        [XafDisplayName("Үзлэг хийсэн огноо"), Size(10), ModelDefault("DisplayFormat", "yyyy:MM:dd")]
        public DateTime date { get { return _date; } set { SetPropertyValue(nameof(date), ref _date, value); } }

        private int _kilometr;
        [XafDisplayName("Км-ээс"), Size(5), VisibleInListView(false)]
        public int kilometr { get { return _kilometr; } set { SetPropertyValue(nameof(kilometr), ref _kilometr, value); } }

        private int _kilometrs;
        [XafDisplayName("Км хүртэл"), Size(5), VisibleInListView(false)]
        public int kilometrs { get { return _kilometrs; } set { SetPropertyValue(nameof(kilometrs), ref _kilometrs, value); } }

        private int _totalKilometrs;
        [XafDisplayName("Бүх Км"), Size(5), VisibleInListView(false)]
        public int totalKilometrs { get { return _totalKilometrs; } set { SetPropertyValue(nameof(totalKilometrs), ref _totalKilometrs, value); } }

        private string _startCoordinateLength;
        [XafDisplayName("Эхлэл цэгийн солбилцолын уртраг"), Size(15), VisibleInListView(false)]
        public string startCoordinateLength { get { return _startCoordinateLength; } set { SetPropertyValue(nameof(startCoordinateLength), ref _startCoordinateLength, value); } }

        private string _startCoordinateLatitude;
        [XafDisplayName("Эхлэл цэгийн солбилцолын өргөрөг"), Size(15), VisibleInListView(false)]
        public string startCoordinateLatitude { get { return _startCoordinateLatitude; } set { SetPropertyValue(nameof(startCoordinateLatitude), ref _startCoordinateLatitude, value); } }

        private string _endCoordinateLength;
        [XafDisplayName("Төгсгөл цэгийн солбилцолын уртраг"), Size(15), VisibleInListView(false)]
        public string endCoordinateLength { get { return _endCoordinateLength; } set { SetPropertyValue(nameof(endCoordinateLength), ref _endCoordinateLength, value); } }

        private string _endCoordinateLatitude;
        [XafDisplayName("Төгсгөл цэгийн солбилцолын өргөрөг"), Size(15), VisibleInListView(false)]
        public string endCoordinateLatitude { get { return _endCoordinateLatitude; } set { SetPropertyValue(nameof(endCoordinateLatitude), ref _endCoordinateLatitude, value); } }

        private string _workChairmanName;
        [XafDisplayName("Ажлын хэсгийн даргийн нэр"), Size(15)]
        public string workChairmanName { get { return _workChairmanName; } set { SetPropertyValue(nameof(workChairmanName), ref _workChairmanName, value); } }

        private string _memberName;
        [XafDisplayName("Гишүүдийн нэр"), Size(40), VisibleInListView(false)]
        public string memberName { get { return _memberName; } set { SetPropertyValue(nameof(memberName), ref _memberName, value); } }

        private string _roadManagerCompanyName;
        [XafDisplayName("Зам хариуцагч байгууллагын нэр"), Size(20)]
        public string roadManagerCompanyName { get { return _roadManagerCompanyName; } set { SetPropertyValue(nameof(roadManagerCompanyName), ref _roadManagerCompanyName, value); } }

        private string _position;
        [XafDisplayName("Албан тушаал"), Size(20)]
        public string position { get { return _position; } set { SetPropertyValue(nameof(position), ref _position, value); } }

        private string _name;
        [XafDisplayName("Нэр"), Size(20), VisibleInListView(false)]
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        private int _pavementEdgeEvaluation;
        [XafDisplayName("Хучилт, хөвөөны үнэлгээ"), VisibleInListView(false)]
        public int pavementEdgeEvaluation { get { return _pavementEdgeEvaluation; } set { SetPropertyValue(nameof(pavementEdgeEvaluation), ref _pavementEdgeEvaluation, value); } }

        private int _dartDam;
        [XafDisplayName("Шороон далан, шуудууны үнэлгээ"), VisibleInListView(false)]
        public int dartDam { get { return _dartDam; } set { SetPropertyValue(nameof(dartDam), ref _dartDam, value); } }

        private int _bridgeThroat;
        [XafDisplayName("Гүүр, хоолойны үнэлгээ"), VisibleInListView(false)]
        public int bridgeThroat { get { return _bridgeThroat; } set { SetPropertyValue(nameof(bridgeThroat), ref _bridgeThroat, value); } }

        private int _markRoadEquipment;
        [XafDisplayName("Тэмдэгжилт замын тоноглолын үнэлгээ"), VisibleInListView(false)]
        public int markRoadEquipment { get { return _markRoadEquipment; } set { SetPropertyValue(nameof(markRoadEquipment), ref _markRoadEquipment, value); } }

        private int _roadConstruction;
        [XafDisplayName("Замын байгууламж, тохижилтын үнэлгээ")]
        public int roadConstruction { get { return _roadConstruction; } set { SetPropertyValue(nameof(roadConstruction), ref _roadConstruction, value); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            date = DateTime.Now;
        }
    }
}