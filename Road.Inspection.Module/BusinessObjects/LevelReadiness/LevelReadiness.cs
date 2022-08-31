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

        private double _kmFrom;
        [XafDisplayName("Эхлэх км"), Size(5), VisibleInListView(false)]
        public double kmFrom { get { return _kmFrom; } set { SetPropertyValue(nameof(kmFrom), ref _kmFrom, value); } }

        private double _kmTo;
        [XafDisplayName("Төгсгөл км"), Size(5), VisibleInListView(false)]
        public double kmTo { get { return _kmTo; } set { SetPropertyValue(nameof(kmTo), ref _kmTo, value); } }

        private double _kmTotal;
        [XafDisplayName("Бүх Км"), Size(5), VisibleInListView(false)]
        public double kmTotal { get { return _kmTotal; } set { SetPropertyValue(nameof(kmTotal), ref _kmTotal, value); } }

        private string _startPointN;
        [XafDisplayName("Эхлэл цэгийн уртраг"), Size(15), VisibleInListView(false)]
        public string startPointN { get { return _startPointN; } set { SetPropertyValue(nameof(startPointN), ref _startPointN, value); } }

        private string _startPointE;
        [XafDisplayName("Эхлэл цэгийн өргөрөг"), Size(15), VisibleInListView(false)]
        public string startPointE { get { return _startPointE; } set { SetPropertyValue(nameof(startPointE), ref _startPointE, value); } }

        private string _endPointN;
        [XafDisplayName("Төгсгөл цэгийн уртраг"), Size(15), VisibleInListView(false)]
        public string endPointN { get { return _endPointN; } set { SetPropertyValue(nameof(endPointN), ref _endPointN, value); } }

        private string _endPointE;
        [XafDisplayName("Төгсгөл цэгийн өргөрөг"), Size(15), VisibleInListView(false)]
        public string endPointE { get { return _endPointE; } set { SetPropertyValue(nameof(endPointE), ref _endPointE, value); } }

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
        [XafDisplayName("Тэмдэгжилт, замын тоноглолын үнэлгээ"), VisibleInListView(false)]
        public int markRoadEquipment { get { return _markRoadEquipment; } set { SetPropertyValue(nameof(markRoadEquipment), ref _markRoadEquipment, value); } }

        private int _roadConstruction;
        [XafDisplayName("Замын байгууламж, тохижилтын үнэлгээ")]
        public int roadConstruction { get { return _roadConstruction; } set { SetPropertyValue(nameof(roadConstruction), ref _roadConstruction, value); } }

        private string _subscriberName;
        [XafDisplayName("Захиалагч"), Size(100), VisibleInListView(false)]
        public string subscriberName { get { return _subscriberName; } set { SetPropertyValue(nameof(subscriberName), ref _subscriberName, value); } }

        private string _subscriberPositions;
        [XafDisplayName("Захиалагчийн нэр, албан тушаал"), Size(200), VisibleInListView(false)]
        public string subscriberPositions { get { return _subscriberPositions; } set { SetPropertyValue(nameof(subscriberPositions), ref _subscriberPositions, value); } }

        private string _consultantName;
        [XafDisplayName("Зөвлөх"), Size(100), VisibleInListView(false)]
        public string consultantName { get { return _consultantName; } set { SetPropertyValue(nameof(consultantName), ref _consultantName, value); } }

        private string _consultantPositions;
        [XafDisplayName("Зөвлөхийн нэр, албан тушаал"), Size(200), VisibleInListView(false)]
        public string consultantPositions { get { return _consultantPositions; } set { SetPropertyValue(nameof(consultantPositions), ref _consultantPositions, value); } }

        private string _roadManager;
        [XafDisplayName("Зам хариуцагч"), Size(100)]
        public string roadManager { get { return _roadManager; } set { SetPropertyValue(nameof(roadManager), ref _roadManager, value); } }

        private string _roadPositions;
        [XafDisplayName("Зам хариуцагчийн нэр, албан тушаал"), Size(200)]
        public string roadPositions { get { return _roadPositions; } set { SetPropertyValue(nameof(roadPositions), ref _roadPositions, value); } }

        private string _other;
        [XafDisplayName("Бусад оролцогчид"), Size(500)]
        public string other { get { return _other; } set { SetPropertyValue(nameof(other), ref _other, value); } }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            date = DateTime.Now;
        }
    }
}