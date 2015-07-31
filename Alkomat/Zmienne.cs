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
    public static class Zmienne
    {
        public static double wzrost { get; set; }
        public static double waga { get; set; }
        public static double wiek { get; set; }
        public static double tbw { get; set; }
        public static int iloscDuzePiwo { get; set; }    
        public static int iloscMalePiwo { get; set; }
        public static int iloscLekkiePiwo { get; set; }
        public static int iloscWina { get; set; }
        public static int iloscSzampana { get; set; }
        public static int iloscWodkaMala { get; set; }
        public static int iloscWodkaDuza { get; set; }
        public static double AiloscDuzePiwo { get; set; }
        public static double AiloscMalePiwo { get; set; }
        public static double AiloscLekkiePiwo { get; set; }
        public static double AiloscWina { get; set; }
        public static double AiloscSzampana { get; set; }
        public static double AiloscWodkaMala { get; set; }
        public static double AiloscWodkaDuza { get; set; }
        public static double wspolczynnikA { get; set; }
        public static double czasPicia { get; set; }
        public static double wynik { get; set; }
    }
}