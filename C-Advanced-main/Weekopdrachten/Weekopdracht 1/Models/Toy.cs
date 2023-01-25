using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht_1__Dierenwinkel_.Models
{
    // De Toy class kan gebruik maken van de interface Isellable doormiddel van ": ISellable".
    class Toy : ISellable
    {
        public string DogToy { get; set; }
        public string BirdToy { get; set; }
        public string FishToy { get; set; }

        public void Sell()
        {
            Console.WriteLine("I didn't know there were fish toys");
        }

    }
}
