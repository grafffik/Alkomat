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

namespace Alkomat.Entities
{
    public class Alcohol
    {
        public int ml;
        public double percent;
        public Alcohol(int ml, double percent)
        {
            this.ml = ml;
            this.percent = percent;
        }
    }
}