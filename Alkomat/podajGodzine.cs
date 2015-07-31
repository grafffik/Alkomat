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
            zegar.Click += Zegar_Click;
            Button buttonPodajGodzine = FindViewById<Button>(Resource.Id.buttonPodajGodzine);
            buttonPodajGodzine.Click += ButtonPodajGodzine_Click;

        }

        private void ButtonPodajGodzine_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Zegar_Click(object sender, EventArgs e)
        {
            godziny = DateTime.Now.Hour;
            minuty = DateTime.Now.Minute;
        }
    }
}