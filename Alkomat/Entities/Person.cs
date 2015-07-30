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

namespace Alkomat.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; } //kg
        public int Height { get; set; } //cm
        public int Old { get; set; } //years 
        public string Sex { get; set; }//"Female"

        //public Dranked _Dranked { get; set; }
        //public Reduction _Reduction { get; set; }
        //public Alkolator _Calculator { get; set; }

        public Person(string name, string sex, int weight, int height, int old)
        {
            this.Name = name;
            this.Sex = sex;
            this.Weight = weight;
            this.Height = height;
            this.Old = old;
        }

        public List<int> GetPersonStats()
        {
            var values = new List<int>();
            values.Add(Weight);
            values.Add(Height);
            if (Sex == "Male")
                values.Add(Old);
            return values;
        }
    }
}