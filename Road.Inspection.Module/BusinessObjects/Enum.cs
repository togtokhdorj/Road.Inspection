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

    public enum Evaluation
    {
        [XafDisplayName("Сонгох")]
        O = 0,
        [XafDisplayName("2")]
        O2 = 2,
        [XafDisplayName("3")]
        O3 = 3,
        [XafDisplayName("4")]
        O4 = 4,
        [XafDisplayName("5")]
        O5 = 5

    }
}