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
    [Activity(Label = "ObliczPromile")]
    public class ObliczPromile : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.ObliczPromile);

            Button buttonObliczPromileDalej = FindViewById<Button>(Resource.Id.buttonObliczPromileDalej);
            buttonObliczPromileDalej.Click += ButtonObliczPromileDalej_Click;

            
        }

        private void ButtonObliczPromileDalej_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(podajGodzine));
            this.StartActivity(intent);
        }
    }
}