using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht_1__Dierenwinkel_.Models
{
    // De Bird class inherant van de Animal class doormiddel van de ": Animal".
    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Tweet");
        }

        public void FlyLikeTheWind()
        {
            Console.WriteLine("*Flies gracefully with feathers as soft as silk, free without a care in the world*");
        }
    }
}
