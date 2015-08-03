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

            Button buttonObliczPromileDalej = FindViewById<Button>(Resource.Id.buttonObliczPromileDalej);

            tv1= FindViewById<TextView>(Resource.Id.tv1);
            tv2= FindViewById<TextView>(Resource.Id.tv2);
            tv3= FindViewById<TextView>(Resource.Id.tv3);
            tv4= FindViewById<TextView>(Resource.Id.tv4);
            tv5= FindViewById<TextView>(Resource.Id.tv5);
            tv6= FindViewById<TextView>(Resource.Id.tv6);
            tv7= FindViewById<TextView>(Resource.Id.tv7);

            buttonObliczPromileDalej.Click += ButtonObliczPromileDalej_Click;            
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
 
 
 
 
 