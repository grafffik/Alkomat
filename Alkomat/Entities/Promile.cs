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
    public class Promile
    {
        public double Value {get; set;}
        public int MinutesPassed { get; set; }

        public void Set(Person person)
        {
            this.Value = (person._Dranked.Value / person._Reduction.Value) * 0.8;
            this.MinutesPassed = 0;
        }
        public void Process(int minutes, double ratio)
        {
            this.Value = Value - (minutes * ratio);
            ++MinutesPassed;
        }
        public Promile(Promile promile)
        {
            this.Value = promile.Value;
            this.MinutesPassed = promile.MinutesPassed;
        }
        public Promile()
        {
            this.MinutesPassed = 0;
            this.Value = 0;
        }
    }
}