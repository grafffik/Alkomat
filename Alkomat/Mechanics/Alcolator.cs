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

namespace Alkomat.Mechanics
{
    public static class Alcolator
    {
        public static void Wyliczamy()
        {
            /*
            Wynik = (A/TBW)*0.8 - (T*e)
            gdzie:
            Wynik - zawarto�� alkoholu we krwi w promilach
            A - wspolczynnik ilo�ci wypitego czystego alkoholu w gramach
            T - czas sp�dzony na spo�ywaniu produkt�w alkoholowych (w godzinach)
            e - wsp�czynnik eliminacji alkoholu z organizmu wynosz�cy: 0.2 promila na godzin� dla os�b pij�cych cz�sto
            */
            Zmienne.wynik = 0;
            var tbw = Zmienne.tbw;
            var wspolczynnikA = Zmienne.wspolczynnikA;
            var czasPicia = Zmienne.czasPicia;
            var wynik = Zmienne.wynik;

            wynik = (wspolczynnikA / tbw) * 0.8 - (czasPicia * 0.2);
            Zmienne.wynik = wynik;

        }
    }
}
 