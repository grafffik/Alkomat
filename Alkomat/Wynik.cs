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

            Alcolator.Wyliczamy();
            Alcolator.KiedyTrzezwy();
            Button buttonWynik = FindViewById<Button>(Resource.Id.buttonWynik);
            go1 = DateTime.Now.Hour;
            mi1 = DateTime.Now.Minute;

            textView_AktulnePromile = FindViewById<TextView>(Resource.Id.textView_AktulnePromile);
            textView_AktulnePromile.Text = Math.Round(Zmienne.wynik, 2).ToString();
            textView_AktulnePromile.Text = textView_AktulnePromile.Text + '‰';
            
            double pob = Zmienne.wynik2;            
            
            TextView_WytrzezwiejeszGodzina = FindViewById<TextView>(Resource.Id.TextView_WytrzezwiejeszGodzina);
            TextView_WytrzezwiejeszGodzina.Text = ToTime(pob);
            TextView_WytrzezwiejeszGodzina.Text = TextView_WytrzezwiejeszGodzina.Text.Replace(',', ':');
            if (Zmienne.wynik<=0)
            {
                TextView_WytrzezwiejeszGodzina.Text = "nie dotyczy";
            }
            else
            TextView_WytrzezwiejeszGodzina.Text = "o godz: " + TextView_WytrzezwiejeszGodzina.Text;

            TextView_DopuszczalneStezenieGodzina = FindViewById<TextView>(Resource.Id.TextView_DopuszczalneStezenieGodzina);

            double pob2 = pob - 1.25;

            TextView_DopuszczalneStezenieGodzina.Text = ToTime(pob2);
            TextView_DopuszczalneStezenieGodzina.Text = TextView_DopuszczalneStezenieGodzina.Text.Replace(',', ':');
            if (Zmienne.wynik <= 0)
            {
                TextView_DopuszczalneStezenieGodzina.Text = "nie dotyczy";
            }
            else
                TextView_DopuszczalneStezenieGodzina.Text = "o godz: " + TextView_DopuszczalneStezenieGodzina.Text;

            buttonWynik.Click += buttonWynik_Click;
        }

        private string ToTime(double pob)
        {

            string godzinka = Math.Round(pob, 2).ToString();
            List<string> temp = new List<string>();

            temp.AddRange(godzinka.Split(','));
            if (temp.Count == 1)
            {
                temp.Clear();
                temp.AddRange(godzinka.Split('.'));
            }

            int hour = Convert.ToInt32(temp[0]); 
            int minutes = Convert.ToInt32(temp[1]);
            if (minutes > 60)
                hour++;
            minutes = minutes % 60;
            

            hour = hour % 24;
            godzinka = "";
            godzinka = hour.ToString() + ":";
            if (minutes < 10)
                godzinka += "0" + minutes.ToString();
            else
                godzinka += minutes.ToString();
            return godzinka;
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }
    }
}