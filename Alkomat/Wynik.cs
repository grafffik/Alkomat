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
        TextView TextView_WytrzezwiejeszGodzina;
        TextView TextView_DopuszczalneStezenieGodzina;
        double go1;
        double mi1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Wynik);

            // Create your application here
            DateTime godzinaDopuszczalna;
            DateTime godzinaWytrzezwienia;

            Alcolator.Wyliczamy();
            Alcolator.KiedyTrzezwy();
            Button buttonWynik = FindViewById<Button>(Resource.Id.buttonWynik);
            go1 = DateTime.Now.Hour;
            mi1 = DateTime.Now.Minute;

            textView_AktulnePromile = FindViewById<TextView>(Resource.Id.textView_AktulnePromile);
            textView_AktulnePromile.Text = Math.Round(Zmienne.wynik, 2).ToString();
            textView_AktulnePromile.Text = textView_AktulnePromile.Text + '‰';

            Zmienne.godzinaWytrzezwienia = DateTime.Now;
            Zmienne.godzinaWytrzezwienia.AddHours(Zmienne.wynik2);
            double pob = Zmienne.wynik2;
            if (pob>24)
            {
                double a = pob - 24;
                pob = a;
            }

            TextView_WytrzezwiejeszGodzina = FindViewById<TextView>(Resource.Id.TextView_WytrzezwiejeszGodzina);
            TextView_WytrzezwiejeszGodzina.Text = Zmienne.godzinaWytrzezwienia.ToShortTimeString();
            TextView_WytrzezwiejeszGodzina.Text = TextView_WytrzezwiejeszGodzina.Text.Replace(',', ':');
            TextView_WytrzezwiejeszGodzina.Text = "o godz: " + TextView_WytrzezwiejeszGodzina.Text;

            TextView_DopuszczalneStezenieGodzina = FindViewById<TextView>(Resource.Id.TextView_DopuszczalneStezenieGodzina);

            double pob2 = pob - 1;
            if (pob2>24)
            {
                double b = pob2 - 24;
                pob2 = b;
            }
            Zmienne.godzinaDopuszczalna = DateTime.Now;
            Zmienne.godzinaDopuszczalna.AddHours(pob2);

            TextView_DopuszczalneStezenieGodzina.Text = Zmienne.godzinaDopuszczalna.ToShortTimeString();
            TextView_DopuszczalneStezenieGodzina.Text = TextView_DopuszczalneStezenieGodzina.Text.Replace(',', ':');
            TextView_DopuszczalneStezenieGodzina.Text = "o godz: " + TextView_DopuszczalneStezenieGodzina.Text;

            buttonWynik.Click += buttonWynik_Click;
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }
    }
}