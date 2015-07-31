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
        public static void ExampleTest()
        {
            Alcohol beer = new Alcohol(500, 5.5);
            Alcohol vodka = new Alcohol(100, 40.0);

            //tworzy nowa osobe, funkcja tworzaca odrazu wylicza Redukcje Alkoholu u osoby
            Person jerry = new Person("Jaros³aw", "Male", Globals._averageRatio, 160, 210, 38);
            //jerry pije piwko, wodke i znowu piwko
            jerry.Drink(beer);
            jerry.Drink(vodka);
            jerry.Drink(beer);

            //Set wylicza zawartosc alkoholu we krwi dla danej osoby w promilach
            //( korzysta z redukcji osoby i akutalnego poziomu alkoholu w gramach ._Dranked.Value-ilosc alko w gramach
            var aktualnyPromil = jerry.GetPromile();
            jerry.PoMinutach(60);
            jerry.Drink(beer);
            var poGodziniePromil = jerry.GetPromile();
            jerry.PoMinutach(300);
            var Po5godzinach = jerry.GetPromile();
            //przeliczenie alko po 60 minutach, Ratio to spalanie alko/minute np. 60 * 0.20
           // jerry.StartPromile.Process(60, jerry.Ratio);
           // var poGodziniePromil = jerry.StartPromile.Value;
           
            //Globals._allowedAmount;

        }
    }
}