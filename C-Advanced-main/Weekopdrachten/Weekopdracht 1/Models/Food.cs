using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Weekopdracht_1__Dierenwinkel_.Models
{
    // De Food class kan gebruik maken van de interface Isellable doormiddel van ": ISellable".
    class Food : ISellable
    {
        public string DogFood { get; set; }
        public string BirdFood { get; set; }
        public string Fishfood { get; set; }

        public virtual void Sell()
        {
            Console.WriteLine("*Smells better than euroshopper*");
        }

    }
  
}
