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
        [XafDisplayName("Нарлаг")]
        Sunny = 1,
        [XafDisplayName("Бүрхэг")]
        Cloudy = 2,
        [XafDisplayName("Бороотой")]
        Raining = 3,
        [XafDisplayName("Цастай")]
        Snowing = 4,
        [XafDisplayName("Сол.Үүл")]
        RainbowClouds = 5,
        [XafDisplayName("Хүчтэй салхитай")]
        StrongWinds = 6
    }
}