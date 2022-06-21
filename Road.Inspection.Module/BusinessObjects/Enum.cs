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
    public enum WeatherConditions
    {
        None = 0,
        Sunny = 1,
        Cloudy = 2,
        Raining = 3,
        Snowing = 4,
        RainbowClouds = 5,
        StrongWinds = 6
    }
}