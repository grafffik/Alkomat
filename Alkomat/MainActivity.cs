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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            Alcolator.ExampleTest();
            SetContentView(Resource.Layout.Main);            

            RadioButton radio_kob = FindViewById<RadioButton>(Resource.Id.radioButton1);
            RadioButton radio_mez = FindViewById<RadioButton>(Resource.Id.radioButton2);

            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText editText2 = FindViewById<EditText>(Resource.Id.editText2);
            EditText editText3 = FindViewById<EditText>(Resource.Id.editText3);

            Zmienne.wzrost = Convert.ToDouble(editText1);
            Zmienne.waga = Convert.ToDouble(editText2);
            Zmienne.wiek = Convert.ToDouble(editText3);

            Button buttonDalej = FindViewById<Button>(Resource.Id.buttonDalej);
            buttonDalej.Click += ButtonDalej_Click;

            // wyliczanie ilości płynów ustrojowych w organizmie dla kobiety i mężczyzny
            
            if (radio_kob.Checked)
            {
                Zmienne.tbw = -2.097 + (0.1069 * Zmienne.wzrost) + (0.2466 * Zmienne.waga);
            }
            else if (radio_mez.Checked)
            {
                Zmienne.tbw = 2.447 - (0.09156 * Zmienne.wiek) + (0.1074 * Zmienne.wzrost) + (0.3362 * Zmienne.waga);
            }
            // TBW wysyłamy do klasy oblicz promile
        }

        private void ButtonDalej_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ObliczPromile));
            this.StartActivity(intent);
        }
    }
}