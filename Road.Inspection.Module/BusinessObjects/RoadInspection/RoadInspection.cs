using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Road.Inspection.Module.BusinessObjects
{
    [DefaultClassOptions]
    [XafDisplayName("Авто замын үзлэг")]
    public class RoadInspection : BaseObject
    {
        public RoadInspection(Session session) : base(session) { }

        private DateTime _date;
        [XafDisplayName("Огноо"), ModelDefault("DisplayFormat", "yyyy-MM-dd")]
        public DateTime date { get { return _date; } set { SetPropertyValue(nameof(date), ref _date, value); } }

        private string _teamLeader;
        [XafDisplayName("Багийн ахлагч")]
        public string teamLeader { get { return _teamLeader; } set { SetPropertyValue(nameof(teamLeader), ref _teamLeader, value); } }

        private string _inspectionEngineer;
        [XafDisplayName("Үзлэгийн инженер"), VisibleInListView(false)]
        public string inspectionEngineer { get { return _inspectionEngineer; } set { SetPropertyValue(nameof(inspectionEngineer), ref _inspectionEngineer, value); } }

        private string _measuringInstrument;
        [XafDisplayName("Хэмжилтийн хэрэгсэл"), VisibleInListView(false)]
        public string measuringInstrument { get { return _measuringInstrument; } set { SetPropertyValue(nameof(measuringInstrument), ref _measuringInstrument, value); } }

        private string _other;
        [XafDisplayName("Бусад"), VisibleInListView(false), Size(500)]
        public string other { get { return _other; } set { SetPropertyValue(nameof(other), ref _other, value); } }

        private string _markType;
        [XafDisplayName("Марк, төрөл")]
        public string markType { get { return _markType; } set { SetPropertyValue(nameof(markType), ref _markType, value); } }

        private string _plateNumber;
        [XafDisplayName("Улсын дугаар"), Size(20), VisibleInListView(false)]
        public string plateNumber { get { return _plateNumber; } set { SetPropertyValue(nameof(plateNumber), ref _plateNumber, value); } }

        private string _roadNumber;
        [XafDisplayName("Замын дугаар"), Size(20)]
        public string roadNumber { get { return _roadNumber; } set { SetPropertyValue(nameof(roadNumber), ref _roadNumber, value); } }

        private string _roadDirection;
        [XafDisplayName("Замын чиглэл")]
        public string roadDirection { get { return _roadDirection; } set { SetPropertyValue(nameof(roadDirection), ref _roadDirection, value); } }

        private string _category;
        [XafDisplayName("Ангилал /зэрэг/"), VisibleInListView(false)]
        public string category { get { return _category; } set { SetPropertyValue(nameof(category), ref _category, value); } }

        private string _startPointN;
        [XafDisplayName("Эхлэл цэг N"), Size(30), VisibleInListView(false)]
        public string startPointN { get { return _startPointN; } set { SetPropertyValue(nameof(startPointN), ref _startPointN, value); } }

        private string _startPointE;
        [XafDisplayName("Эхлэл цэг E"), Size(30), VisibleInListView(false)]
        public string startPointE { get { return _startPointE; } set { SetPropertyValue(nameof(startPointE), ref _startPointE, value); } }

        private string _endPointN;
        [XafDisplayName("Төгсгөлийн цэг N"), Size(30), VisibleInListView(false)]
        public string endPointN { get { return _endPointN; } set { SetPropertyValue(nameof(endPointN), ref _endPointN, value); } }

        private string _endPointE;
        [XafDisplayName("Төгсгөлийн цэг E"), Size(30), VisibleInListView(false)]
        public string endPointE { get { return _endPointE; } set { SetPropertyValue(nameof(endPointE), ref _endPointE, value); } }

        private string _kilometr;
        [VisibleInListView(false), XafDisplayName("Эхлэх км"), Size(20)]
        public string kilometr { get { return _kilometr; } set { SetPropertyValue(nameof(kilometr), ref _kilometr, value); } }

        private string _kilometrs;
        [XafDisplayName("Төгсгөл км"), Size(20), VisibleInListView(false)]
        public string kilometrs { get { return _kilometrs; } set { SetPropertyValue(nameof(kilometrs), ref _kilometrs, value); } }

        private string _weather;
        [XafDisplayName("Цаг агаарын байдал"), VisibleInListView(false)]
        public string weather { get { return _weather; } set { SetPropertyValue(nameof(weather), ref _weather, value); } }

        private string _degrees;
        [XafDisplayName("Өдрийн хэм"), Size(10),VisibleInListView(false)]
        public string degrees { get { return _degrees; } set { SetPropertyValue(nameof(degrees), ref _degrees, value); } }

        private string _beforeLaneDate;
        [XafDisplayName("Урдах үзлэгийн огноо"), Size(20), VisibleInListView(false)]
        public string beforeLaneDate { get { return _beforeLaneDate; } set { SetPropertyValue(nameof(beforeLaneDate), ref _beforeLaneDate, value); } }

        private string _beforeLeftLane;
        [XafDisplayName("Урдах үзлэгийн зүүн зорчих"), Size(5), VisibleInListView(false)]
        public string beforeLeftLane { get { return _beforeLeftLane; } set { SetPropertyValue(nameof(beforeLeftLane), ref _beforeLeftLane, value); } }

        private string _beforeRightLane;
        [XafDisplayName("Урдах үзлэгийн баруун зорчих"), Size(5), VisibleInListView(false)]
        public string beforeRightLane { get { return _beforeRightLane; } set { SetPropertyValue(nameof(beforeRightLane), ref _beforeRightLane, value); } }

        private string _currentLeftLane;
        [XafDisplayName("Одоогийн зүүн зорчих"), Size(5), VisibleInListView(false)]
        public string currentLeftLane { get { return _currentLeftLane; } set { SetPropertyValue(nameof(currentLeftLane), ref _currentLeftLane, value); } }

        private string _currentRightLane;
        [XafDisplayName("Одоогийн баруун зорчих"), Size(5), VisibleInListView(false)]
        public string currentRightLane { get { return _currentRightLane; } set { SetPropertyValue(nameof(currentRightLane), ref _currentRightLane, value); } }

        private string _specialNote;
        [XafDisplayName("Онцгой тэмдэглэл"), Size(500), VisibleInListView(false)]
        public string specialNote { get { return _specialNote; } set { SetPropertyValue(nameof(specialNote), ref _specialNote, value); } }

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

        private string _companyName;
        [XafDisplayName("Бусад оролцогчид"), Size(500)]
        public string companyName { get { return _companyName; } set { SetPropertyValue(nameof(companyName), ref _companyName, value); } }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Зорчих хэсэг, хучлага")]
        public XPCollection<RoadLane> lanes { get { return GetCollection<RoadLane>(nameof(lanes)); } }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Тоноглол")]
        public XPCollection<SmoothnessRoadway> smoothnessRoadways { get { return GetCollection<SmoothnessRoadway>(nameof(smoothnessRoadways)); } }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Ус зайлуулалт, шуудуу, хоолой")]
        public XPCollection<RoadDrainge> drainges { get { return GetCollection<RoadDrainge>(nameof(drainges)); } }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Хөвөө, хажуу налуу, зогсоолын талбай")]
        public XPCollection<RoadEdgeSideSlope> roadEdgeSideSlopes { get { return GetCollection<RoadEdgeSideSlope>(nameof(roadEdgeSideSlopes)); } }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Үйлчилгээний байгууламж")]
        public XPCollection<RoadServiceFacility> roadServiceFacilities { get { return GetCollection<RoadServiceFacility>(nameof(roadServiceFacilities)); } }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Гүүрэнд")]
        public XPCollection<RoadBridgeInjury> injurys { get { return GetCollection<RoadBridgeInjury>(nameof(injurys)); } }
    }
}