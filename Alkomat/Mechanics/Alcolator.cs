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
            Wynik - zawartoœæ alkoholu we krwi w promilach
            A - wspolczynnik iloœci wypitego czystego alkoholu w gramach
            T - czas spêdzony na spo¿ywaniu produktów alkoholowych (w godzinach)
            e - wspó³czynnik eliminacji alkoholu z organizmu wynosz¹cy: 0.2 promila na godzinê dla osób pij¹cych czêsto
            */
            Zmienne.wynik = 0;
            var tbw = Zmienne.tbw;
            var wspolczynnikA = Zmienne.wspolczynnikA;
            var czasPicia = Zmienne.czasPicia;
            var wynik = Zmienne.wynik;

            wynik = (wspolczynnikA / tbw) * 0.8 - (czasPicia * 0.2);           
           

        }
    }
}
 