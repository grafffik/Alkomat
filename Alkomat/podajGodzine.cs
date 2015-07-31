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
        private int godziny;
        private int minuty;

        const int TIME_DIALOG_ID = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.podajGodzine);

            // Create your application here
            TimePicker zegar = FindViewById<TimePicker>(Resource.Id.timePicker1);
            zegar.Click += Zegar_Click1;
            Button buttonPodajGodzine = FindViewById<Button>(Resource.Id.buttonPodajGodzine);
            buttonPodajGodzine.Click += ButtonPodajGodzine_Click;

            godziny = DateTime.Now.Hour;
            minuty = DateTime.Now.Minute;
            double czasObecny = godziny + (minuty / 60);

            // czasPicia = czasObecny - czas z timePickera
            // tyle ze w nim jest czas am/ap. trzeba ustawiæ 24h

        }

        private void Zegar_Click1(object sender, EventArgs e)
        {
           
        }

        private void ButtonPodajGodzine_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Reklama));
            this.StartActivity(intent);
        }

        
    }
}