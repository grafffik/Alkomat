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

namespace Alkomat
{
    [Activity(Label = "podajGodzine")]
    public class podajGodzine : Activity
    {
        int godziny1;
        int minuty1;
        double czas1;
        double g2;
        double m2;
        double czas2;

        const int TIME_DIALOG_ID = 0;

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.podajGodzine);

            Zmienne.czasPicia = 0;

            // Create your application here
            TimePicker zegar = FindViewById<TimePicker>(Resource.Id.timePicker1);
            zegar.SetIs24HourView(Java.Lang.Boolean.True);
            

            godziny1 = DateTime.Now.Hour;
            minuty1 = DateTime.Now.Minute;

            double g1 = Convert.ToDouble(godziny1);
            double m1 = Convert.ToDouble(minuty1);
            czas1 = g1 + (m1 / 60);

            g2 = Convert.ToInt32(zegar.CurrentHour);
            m2 = Convert.ToInt32(zegar.CurrentMinute);

            czas2 = g2 + (m2 / 60);
            Zmienne.czasPicia = czas1 - czas2;            
            
            Button buttonPodajGodzine = FindViewById<Button>(Resource.Id.buttonPodajGodzine);
            buttonPodajGodzine.Click += ButtonPodajGodzine_Click;

        }

        private void ButtonPodajGodzine_Click(object sender, EventArgs e)
        {            
            Intent intent = new Intent(this, typeof(Reklama));
            this.StartActivity(intent);
        }        
    }
}