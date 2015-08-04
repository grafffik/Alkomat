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
            Zmienne.wynik = 0;
            var tbw = Zmienne.tbw;
            var wspolczynnikA = Zmienne.wspolczynnikA;
            var czasPicia = Zmienne.czasPicia;
            var wynik = Zmienne.wynik;

            wynik = (wspolczynnikA / tbw) * 0.8 - (czasPicia * 0.2);
            Zmienne.wynik = wynik;
        }
        public static void KiedyTrzezwy()
        {
            Zmienne.wynik2 = 0;
            var tbw = Zmienne.tbw;
            var wspolczynnikA = Zmienne.wspolczynnikA;
            var czasPicia = Zmienne.czasPicia;
            var czas1 = Zmienne.czas1;
            var wynik = Zmienne.wynik;
            var wynik2 = Zmienne.wynik2;

            //tu liczy standardowo promile
            wynik = (wspolczynnikA / tbw) * 0.8 - (czasPicia * 0.15);
           
            //czlowiek trze�wieje 0,15 na godzine, wi�c liczymy ile godzin zejdzie si� aby zbi� promile do 0.
            //otrzymujemy liczbe godzin i minut po przecinku
            wynik2 = wynik / 0.15;

            //dodajemuy do tego warto�� obecnego czasu 
            wynik2 = wynik2 + Zmienne.czas1;
            Zmienne.wynik2 = wynik2;
            Zmienne.godzinaDopuszczalna.AddHours(wynik2);
        }
    }
}
 