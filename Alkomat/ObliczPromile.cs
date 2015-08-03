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
using Alkomat.Entities;
using Alkomat.Mechanics;

namespace Alkomat
{
    [Activity(Label = "ObliczPromile")]
    public class ObliczPromile : Activity
    {
        TextView tv1;
        TextView tv2;
        TextView tv3;
        TextView tv4;
        TextView tv5;
        TextView tv6;
        TextView tv7;
        Button buttonM1;
        Button buttonM2;
        Button buttonM3;
        Button buttonM4;
        Button buttonM5;
        Button buttonM6;
        Button buttonM7;
        Button buttonP1;
        Button buttonP2;
        Button buttonP3;
        Button buttonP4;
        Button buttonP5;
        Button buttonP6;
        Button buttonP7;
        int w1;
        int w2;
        int w3;
        int w4;
        int w5;
        int w6;
        int w7;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.ObliczPromile);

            Zmienne.iloscDuzePiwo = 0;
            Zmienne.iloscMalePiwo = 0;
            Zmienne.iloscLekkiePiwo = 0;
            Zmienne.iloscWina = 0;
            Zmienne.iloscSzampana = 0;
            Zmienne.iloscWodkaMala = 0;
            Zmienne.iloscWodkaDuza = 0;
            Zmienne.wspolczynnikA = 0;

            w1 = 0;
            w2 = 0;
            w3 = 0;
            w4 = 0;
            w5 = 0;
            w6 = 0;
            w7 = 0;

            Button buttonObliczPromileDalej = FindViewById<Button>(Resource.Id.buttonObliczPromileDalej);

            tv1 = FindViewById<TextView>(Resource.Id.tv1);
            tv2 = FindViewById<TextView>(Resource.Id.tv2);
            tv3 = FindViewById<TextView>(Resource.Id.tv3);
            tv4 = FindViewById<TextView>(Resource.Id.tv4);
            tv5 = FindViewById<TextView>(Resource.Id.tv5);
            tv6 = FindViewById<TextView>(Resource.Id.tv6);
            tv7 = FindViewById<TextView>(Resource.Id.tv7);

            buttonM1 = FindViewById<Button>(Resource.Id.buttonM1);
            buttonM2 = FindViewById<Button>(Resource.Id.buttonM2);
            buttonM3 = FindViewById<Button>(Resource.Id.buttonM3);
            buttonM4 = FindViewById<Button>(Resource.Id.buttonM4);
            buttonM5 = FindViewById<Button>(Resource.Id.buttonM5);
            buttonM6 = FindViewById<Button>(Resource.Id.buttonM6);
            buttonM7 = FindViewById<Button>(Resource.Id.buttonM7);
            buttonP1 = FindViewById<Button>(Resource.Id.buttonP1);
            buttonP2 = FindViewById<Button>(Resource.Id.buttonP2);
            buttonP3 = FindViewById<Button>(Resource.Id.buttonP3);
            buttonP4 = FindViewById<Button>(Resource.Id.buttonP4);
            buttonP5 = FindViewById<Button>(Resource.Id.buttonP5);
            buttonP6 = FindViewById<Button>(Resource.Id.buttonP6);
            buttonP7 = FindViewById<Button>(Resource.Id.buttonP7);

            buttonP1.Click += ButtonP1_Click;
            buttonP2.Click += ButtonP2_Click;
            buttonP3.Click += ButtonP3_Click;
            buttonP4.Click += ButtonP4_Click;
            buttonP5.Click += ButtonP5_Click;
            buttonP6.Click += ButtonP6_Click;
            buttonP7.Click += ButtonP7_Click;

            buttonM1.Click += ButtonM1_Click;
            buttonM2.Click += ButtonM2_Click;
            buttonM3.Click += ButtonM3_Click;
            buttonM4.Click += ButtonM4_Click;
            buttonM5.Click += ButtonM5_Click;
            buttonM6.Click += ButtonM6_Click;
            buttonM7.Click += ButtonM7_Click;

            buttonObliczPromileDalej.Click += ButtonObliczPromileDalej_Click;            
        }

        private void ButtonM7_Click(object sender, EventArgs e)
        {
            if (w7 > 0)
            {
                --w7;
            }
            else
            {
                w7 = 0;
            }
            tv7.Text = Convert.ToString(w7);
        }

        private void ButtonM6_Click(object sender, EventArgs e)
        {
            if (w6 > 0)
            {
                --w6;
            }
            else
            {
                w6 = 0;
            }
            tv6.Text = Convert.ToString(w6);
        }

        private void ButtonM5_Click(object sender, EventArgs e)
        {
            if (w5 > 0)
            {
                --w5;
            }
            else
            {
                w5 = 0;
            }
            tv5.Text = Convert.ToString(w5);
        }

        private void ButtonM4_Click(object sender, EventArgs e)
        {
            if (w4 > 0)
            {
                --w4;
            }
            else
            {
                w4 = 0;
            }
            tv4.Text = Convert.ToString(w4);
        }

        private void ButtonM3_Click(object sender, EventArgs e)
        {
            if (w3 > 0)
            {
                --w3;
            }
            else
            {
                w3 = 0;
            }
            tv3.Text = Convert.ToString(w3);
        }

        private void ButtonM2_Click(object sender, EventArgs e)
        {
            if (w2 > 0)
            {
                --w2;
            }
            else
            {
                w2 = 0;
            }
            tv2.Text = Convert.ToString(w2);
        }
        private void ButtonM1_Click(object sender, EventArgs e)
        {
            if (w1 > 0)
            {
                --w1;
            }
            else
            {
                w1 = 0;
            }
            tv1.Text = Convert.ToString(w1);
        }
        private void ButtonP7_Click(object sender, EventArgs e)
        {
            ++w7;
            tv7.Text = Convert.ToString(w7);
        }

        private void ButtonP6_Click(object sender, EventArgs e)
        {
            ++w6;
            tv6.Text = Convert.ToString(w6);
        }

        private void ButtonP5_Click(object sender, EventArgs e)
        {
            ++w5;
            tv5.Text = Convert.ToString(w5);
        }

        private void ButtonP4_Click(object sender, EventArgs e)
        {
            ++w4;
            tv4.Text = Convert.ToString(w4);
        }

        private void ButtonP3_Click(object sender, EventArgs e)
        {
            ++w3;
            tv3.Text = Convert.ToString(w3);
        }       

        private void ButtonP2_Click(object sender, EventArgs e)
        {
            ++w2;
            tv2.Text = Convert.ToString(w2);
        }

        private void ButtonP1_Click(object sender, EventArgs e) {
            ++w1;
            tv1.Text = Convert.ToString(w1);
        }
        

        public void zsumujMelanz()
        {
            Zmienne.iloscDuzePiwo = Convert.ToInt32(tv1.Text);
            Zmienne.iloscMalePiwo = Convert.ToInt32(tv2.Text);
            Zmienne.iloscLekkiePiwo = Convert.ToInt32(tv3.Text);
            Zmienne.iloscWina = Convert.ToInt32(tv4.Text);
            Zmienne.iloscSzampana = Convert.ToInt32(tv5.Text);
            Zmienne.iloscWodkaMala = Convert.ToInt32(tv6.Text);
            Zmienne.iloscWodkaDuza = Convert.ToInt32(tv7.Text);

            double AiloscDuzePiwo = Zmienne.iloscDuzePiwo * 500 * 0.05 * 0.79;
            double AiloscMalePiwo = Zmienne.iloscMalePiwo * 330 * 0.05 * 0.79;
            double AiloscLekkiePiwo = Zmienne.iloscLekkiePiwo * 500 * 0.026 * 0.79;
            double AiloscWina = Zmienne.iloscWina * 100 * 0.16 * 0.79;
            double AiloscSzampana = Zmienne.iloscSzampana * 200 * 0.08 * 0.79;
            double AiloscWodkaMala = Zmienne.iloscWodkaMala * 30 * 0.4 * 0.79;
            double AiloscWodkaDuza = Zmienne.iloscWodkaDuza * 50 * 0.4 * 0.79;

            Zmienne.wspolczynnikA = AiloscDuzePiwo + AiloscMalePiwo + AiloscLekkiePiwo + AiloscWina + AiloscSzampana + AiloscWodkaMala + AiloscWodkaDuza;
            
            //return Zmienne.wspolczynnikA;
        }

        private void ButtonObliczPromileDalej_Click(object sender, EventArgs e)
        {
            zsumujMelanz();
            Intent intent = new Intent(this, typeof(podajGodzine));
            this.StartActivity(intent);
        }
    }
}
 
 
 
 
 