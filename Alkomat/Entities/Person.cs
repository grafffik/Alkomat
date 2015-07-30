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
    //PERSON STATISTICS
    public class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; } //kg
        public int Height { get; set; } //cm
        public int Old { get; set; } //years 
        public string Sex { get; set; }//"Female"
        public double Ratio { get; set; }//spalanie alko na minute

        public Dranked _Dranked { get; set; }
        public Reduction _Reduction { get; set; }

        public Promile StartPromile { get; set; }
        public Promile HighestPromile { get; set; }
        public Promile AllowedPromile { get; set; }

        public Person(string name, string sex, double ratio, int weight, int height, int old = -1)
        {
            this.Name = name;
            this.Sex = sex;
            this.Weight = weight;
            this.Height = height;
            this.Old = old;
            this.Ratio = ratio;

            this._Dranked = new Dranked();
            this._Reduction = new Reduction(this.GetPersonStats());
            this.StartPromile = new Promile();
            this.HighestPromile = new Promile();
            this.AllowedPromile = new Promile();
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

    //PERSON MECHANICS
    public class Dranked
    {
        public double Value { get; set; } //grams

        public void Drink(Alcohol item)
        {
            Value += (item.ml * (item.percent * 0.01) * 0.789);
        }
        public Dranked()
        {
            this.Value = 0.0;
        }
    }
    public class Reduction
    {
        private List<int> Statistics;
        public double Value { get; set; }

        public Reduction(List<int> PersonStats)//0-weight, 1-height, 2-old
        {
            this.Statistics = PersonStats;
            if (this.Statistics.Count == 2)
            {//calc for female
                this.Value = -2.097 + (0.2466 * Statistics[0]) + (0.1069 * Statistics[1]);
            }
            else
            {//calc for male
                this.Value = 2.447 - (0.09156 * Statistics[2]) + (0.1074 * Statistics[1]) + (0.3362 * Statistics[0]);
            }
        }
    }
}