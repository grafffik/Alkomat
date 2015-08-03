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
        const int TIME_DIALOG_ID = 0;
        double czas1;
        double czas2;
        double g1;
        double m1;
        double g2;
        double m2;

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.podajGodzine);

            Zmienne.czasPicia = 0;

            // Create your application here

            //godzina pobierana z telefonu
            g1 = DateTime.Now.Hour;
            m1 = DateTime.Now.Minute;
            
            //suma godzin i minut pobranych z telefonu            
            czas1 = g1 + (m1 / 60);

            //jak wywo³uje siê zegar w nowej metodzie to dziala liczenie, ale zegar jest am/pm
            TimePicker zegar = FindViewById<TimePicker>(Resource.Id.timePicker1);
            zegar.SetIs24HourView(Java.Lang.Boolean.True);

            //pobranie godziny i minut z zegara w apce
            g2 = Convert.ToDouble(zegar.CurrentHour);
            m2 = Convert.ToDouble(zegar.CurrentMinute);
            
            //zsumowanie
            czas2 = g2 + (m2 / 60);

            //Zmienne.czasPicia to ile czasu mine³o od skoñczenia melan¿u do chwili obecnej
            //ostatnia zmienna poczebna do wyniku
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