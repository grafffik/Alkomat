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

            EditText iloscDuzePiwo   = FindViewById<EditText>(Resource.Id.iloscDuzePiwo);
            EditText iloscMalePiwo   = FindViewById<EditText>(Resource.Id.iloscMalePiwo);
            EditText iloscLekkiePiwo = FindViewById<EditText>(Resource.Id.iloscLekkiePiwo);
            EditText iloscWina       = FindViewById<EditText>(Resource.Id.iloscWina);
            EditText iloscSzampana   = FindViewById<EditText>(Resource.Id.iloscSzampana);
            EditText iloscWodkaMala  = FindViewById<EditText>(Resource.Id.iloscWodkaMala);
            EditText iloscWodkaDuza  = FindViewById<EditText>(Resource.Id.iloscWodkaDuza);

            Zmienne.iloscDuzePiwo   = Convert.ToInt16(iloscDuzePiwo);
            Zmienne.iloscMalePiwo   = Convert.ToInt16(iloscMalePiwo);
            Zmienne.iloscLekkiePiwo = Convert.ToInt16(iloscLekkiePiwo);
            Zmienne.iloscWina       = Convert.ToInt16(iloscWina);
            Zmienne.iloscSzampana   = Convert.ToInt16(iloscSzampana);
            Zmienne.iloscWodkaMala  = Convert.ToInt16(iloscWodkaMala);
            Zmienne.iloscWodkaDuza  = Convert.ToInt16(iloscWodkaDuza);
            
            /*
            A = OB*PR*0.79
            gdzie:
            A - iloœæ wypitego czystego alkoholu w gramach
            OB - objêtoœæ napoju w mililitrach
            PR - procentow¹ zawartoœæ alkoholu wyra¿ona w czêœciach setnych np. 5% to 0.05
            0.79 - wspó³czynnik gêstoœci alkoholu etylowego. 
            */

            Zmienne.AiloscDuzePiwo      = Zmienne.iloscDuzePiwo   * 500 * 0.05 * 0.79;
            Zmienne.AiloscMalePiwo      = Zmienne.iloscMalePiwo   * 330 * 0.05 * 0.79;
            Zmienne.AiloscLekkiePiwo    = Zmienne.iloscLekkiePiwo * 500 * 0.026 * 0.79;
            Zmienne.AiloscWina          = Zmienne.iloscWina       * 100 * 0.16 * 0.79;
            Zmienne.AiloscSzampana      = Zmienne.iloscSzampana   * 200 * 0.08 * 0.79;
            Zmienne.AiloscWodkaMala     = Zmienne.iloscWodkaMala  * 30 * 0.4 * 0.79;
            Zmienne.AiloscWodkaDuza     = Zmienne.iloscWodkaDuza  * 50 * 0.4 * 0.79;

            //liczymy ile w sumie wszystkiego zosta³o wyjebane na hejna³
            Zmienne.wspolczynnikA = Zmienne.AiloscDuzePiwo + Zmienne.AiloscMalePiwo + Zmienne.AiloscLekkiePiwo + Zmienne.AiloscWina + Zmienne.AiloscSzampana + Zmienne.AiloscWodkaMala + Zmienne.AiloscWodkaDuza;                       
        }

        private void ButtonObliczPromileDalej_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(podajGodzine));
            this.StartActivity(intent);
        }
    }
}
 
 
 
 
 