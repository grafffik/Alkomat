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

        
        }
    }
}

