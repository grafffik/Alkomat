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

            Person jerry = new Person("Jaros³aw", "Male", 160, 210, 38);

        }
    }
}