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
using Alkomat.Mechanics;

namespace Alkomat
{
    [Activity(Label = "Wynik")]
    public class Wynik : Activity
    {
        TextView textView_AktulnePromile;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Wynik);

            // Create your application here
            Alcolator.Wyliczamy();
            Button buttonWynik = FindViewById<Button>(Resource.Id.buttonWynik);

            textView_AktulnePromile = FindViewById<TextView>(Resource.Id.textView_AktulnePromile);
            textView_AktulnePromile.Text = Math.Round(Zmienne.wynik, 2).ToString();
            textView_AktulnePromile.Text = textView_AktulnePromile.Text + '‰';

           buttonWynik.Click += buttonWynik_Click;
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }
    }
}