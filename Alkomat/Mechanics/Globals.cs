using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Alkomat.Mechanics
{
    public static class Globals
    {
        public  const double _rarelyRatio = 0.10 / 60; //0.1 per hour, 0.1/60 per minute
        public  const double _averageRatio = 0.15 / 60; //0.1 per hour, 0.1/60 per minute
        public  const double _oftenRatio = 0.20 / 60; //0.1 per hour, 0.1/60 per minute
        public  const double _allowedAmount = 0.25;
    }
}