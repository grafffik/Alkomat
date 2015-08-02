using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Alkomat.Entities;
using Alkomat.Mechanics;

namespace Alkomat
{
    [Activity(Label = "Alkomat", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonDalej;
        RadioButton radio_kob;
        RadioButton radio_mez;
        EditText editText1;
        EditText editText2;
        EditText editText3;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Zmienne.tbw = 0;
            Zmienne.wzrost = 0;
            Zmienne.waga = 0;
            Zmienne.wiek = 0;            

            buttonDalej = FindViewById<Button>(Resource.Id.buttonDalej);   
            radio_kob = FindViewById<RadioButton>(Resource.Id.radioButton1);
            radio_mez = FindViewById<RadioButton>(Resource.Id.radioButton2);
            editText1 = FindViewById<EditText>(Resource.Id.editText1);
            editText2 = FindViewById<EditText>(Resource.Id.editText2);
            editText3 = FindViewById<EditText>(Resource.Id.editText3);

            buttonDalej.Click += ButtonDalej_Click;   
        }

        public double zczytajPola()
        {
            //wyczytałem, że dane z edittextów wpierw trzeba do stringa a dopiero potem do double.

            string dane1 = Convert.ToString(editText1);
            string dane2 = Convert.ToString(editText2);
            string dane3 = Convert.ToString(editText3);

            Zmienne.wzrost = Convert.ToDouble(editText1.Text);
            Zmienne.waga = Convert.ToDouble(editText2.Text);
            Zmienne.wiek = Convert.ToDouble(editText3.Text);

            if (radio_kob.Checked)
                Zmienne.tbw = -2.097 + (0.1069 * Zmienne.wzrost) + (0.2466 * Zmienne.waga);
            else if (radio_mez.Checked)
                Zmienne.tbw = 2.447 - (0.09156 * Zmienne.wiek) + (0.1074 * Zmienne.wzrost) + (0.3362 * Zmienne.waga);
            return Zmienne.tbw;
        }

        private void ButtonDalej_Click(object sender, EventArgs e)
        {
            zczytajPola();
            Intent intent = new Intent(this, typeof(ObliczPromile));
            this.StartActivity(intent);
        }

        
    }
}