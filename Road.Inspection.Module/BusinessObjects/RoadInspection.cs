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
    [DefaultClassOptions, XafDefaultProperty(nameof(name))]
    public class RoadInspection : BaseObject
    {
        public RoadInspection(Session session) : base(session) { }

        private string _name;
        public string name { get { return _name; } set { SetPropertyValue(nameof(name), ref _name, value); } }

        private string _teamLeader;
        public string teamLeader { get { return _teamLeader; } set { SetPropertyValue(nameof(teamLeader), ref _teamLeader, value); } }

        private string _inspectionEngineer;
        //[VisibleInListView(false)]
        public string inspectionEngineer { get { return _inspectionEngineer; } set { SetPropertyValue(nameof(inspectionEngineer), ref _inspectionEngineer, value); } }
        
        private string _measuringInstrument;
        //[RuleRequiredField(DefaultContexts.Save)]
        public string measuringInstrument { get { return _measuringInstrument; } set { SetPropertyValue(nameof(measuringInstrument), ref _measuringInstrument, value); }}
       
        private string _other;
        [VisibleInListView(false)]
        public string other { get { return _other; } set { SetPropertyValue(nameof(other), ref _other, value); } }

        private string _markType;
        [VisibleInListView(false), Size(20)]
        public string markType { get { return _markType; } set { SetPropertyValue(nameof(markType), ref _markType, value); } }

        private string _plateNumber;
        [ VisibleInListView(false)]
        public string plateNumber { get { return _plateNumber; } set { SetPropertyValue(nameof(plateNumber), ref _plateNumber, value); } }

        private string _roadNumber;
        [VisibleInListView(false)]
        public string roadNumber { get { return _roadNumber; } set { SetPropertyValue(nameof(roadNumber), ref _roadNumber, value); } }

        private string _roadDirection;
        [VisibleInListView(false)]
        public string roadDirection { get { return _roadDirection; } set { SetPropertyValue(nameof(roadDirection), ref _roadDirection, value); } }
        
        private string _category;
        [VisibleInListView(false)]
        public string category { get { return _category; } set { SetPropertyValue(nameof(category), ref _category, value); } }
       
        private string _startPoint;
        [VisibleInListView(false)]
        public string startPoint { get { return _startPoint; } set { SetPropertyValue(nameof(startPoint), ref _startPoint, value); } }
       
        private string _endPoint;
        [VisibleInListView(false)]
        public string endPoint { get { return _endPoint; } set { SetPropertyValue(nameof(endPoint), ref _endPoint, value); }}
        
        private string _isDelivery;
        [ModelDefault("AllowEdit", "false"), VisibleInListView(false)]
        public string isDelivery { get { return _isDelivery; } set { SetPropertyValue(nameof(isDelivery), ref _isDelivery, value); } }
        
        private string _kilometr;
        //[VisibleInListView(false)]
        public string kilometr { get { return _kilometr; } set { SetPropertyValue(nameof(kilometr), ref _kilometr, value); } }

        private string _kilometrs;
        public string kilometrs { get { return _kilometrs; } set { SetPropertyValue(nameof(kilometrs), ref _kilometrs, value); } }

        private string _endCoordinates;
        public string endCoordinates { get { return _endCoordinates; } set { SetPropertyValue(nameof(endCoordinates), ref _endCoordinates, value); } }

        private WeatherConditions _weather;
        public WeatherConditions weather { get { return _weather; } set { SetPropertyValue(nameof(weather), ref _weather, value); } }
        
        private string _degrees;
        [VisibleInListView(false)]
        public string degrees { get { return _degrees; } set { SetPropertyValue(nameof(degrees), ref _degrees, value); } }
       
        private string _location;
        public string location { get { return _location; } set { SetPropertyValue(nameof(location), ref _location, value); } }

        private int _length;
        [VisibleInListView(false)]
        public int length {  get { return _length; } set { SetPropertyValue(nameof(length), ref _length, value); } }
       
        private int _latitude;
        public int latitude { get { return _latitude; } set { SetPropertyValue(nameof(latitude), ref _latitude, value); } }
       
        private string _measure;
        public string measure { get { return _measure; } set { SetPropertyValue(nameof(measure), ref _measure, value); } }

        private FileData _image;
        [VisibleInListView(false)]
        public FileData image { get { return _image; } set { SetPropertyValue(nameof(image), ref _image, value); } }
        
        private string _beforeInspection;
        [VisibleInListView(false)]
        public string beforeInspection { get { return _beforeInspection; } set { SetPropertyValue(nameof(beforeInspection), ref _beforeInspection, value); }}

        private string _currentInspection;
        [VisibleInListView(false)]
        public string currentInspection { get { return _currentInspection; } set { SetPropertyValue(nameof(currentInspection), ref _currentInspection, value); } }

        //private string _leftLane;
        //[VisibleInListView(false)]
        //public string leftLane { get { return _leftLane; } set { SetPropertyValue(nameof(leftLane), ref _leftLane, value); } }


    }
}