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
        double tbw = Zmienne.tbw;
        double wzrost = Zmienne.wzrost;
        double waga = Zmienne.waga;
        double wiek = Zmienne.wiek;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            //Alcolator.Wyliczamy();
            SetContentView(Resource.Layout.Main);

            Button buttonDalej = FindViewById<Button>(Resource.Id.buttonDalej);   
            RadioButton radio_kob = FindViewById<RadioButton>(Resource.Id.radioButton1);
            RadioButton radio_mez = FindViewById<RadioButton>(Resource.Id.radioButton2);
            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText editText2 = FindViewById<EditText>(Resource.Id.editText2);
            EditText editText3 = FindViewById<EditText>(Resource.Id.editText3);

            buttonDalej.Click += ButtonDalej_Click;   
        }
        public double zczytajPola(EditText editText1, EditText editText2, EditText editText3, RadioButton radio_kob, RadioButton radio_mez)
        {
            //wyczytałem, że dane z edittextów wpierw trzeba do stringa a dopiero potem do double

            string dane1 = Convert.ToString(editText1);
            string dane2 = Convert.ToString(editText2);
            string dane3 = Convert.ToString(editText3);

            wzrost = Convert.ToDouble(dane1);
            waga = Convert.ToDouble(dane2);
            wiek = Convert.ToDouble(dane3);

              
            if (radio_kob.Checked) {
                tbw = -2.097 + (0.1069 * Zmienne.wzrost) + (0.2466 * Zmienne.waga);
                }
            else if (radio_mez.Checked) {
                tbw = 2.447 - (0.09156 * Zmienne.wiek) + (0.1074 * Zmienne.wzrost) + (0.3362 * Zmienne.waga);
                }
            return tbw;
        }

        private void ButtonDalej_Click(object sender, EventArgs e)
        {
            //zczytajPola(tbw);
            Intent intent = new Intent(this, typeof(ObliczPromile));
            this.StartActivity(intent);
        }

        
    }
}