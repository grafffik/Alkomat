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
    [Activity(Label = "Reklama")]
    public class Reklama : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Reklama);

            // Create your application here
            Button buttonReklama = FindViewById<Button>(Resource.Id.buttonReklama);
            buttonReklama.Click += ButtonReklama_Click;
        }

        private void ButtonReklama_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Wynik));
            this.StartActivity(intent);
        }
    }
}