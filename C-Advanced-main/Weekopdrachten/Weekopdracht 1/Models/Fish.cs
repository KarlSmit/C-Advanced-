using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht_1__Dierenwinkel_.Models
{
    // De Fish class inherant van de Animal class doormiddel van de ": Animal".
    class Fish : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Blub");
        }

        public void Swim()
        {
            Console.WriteLine("*It swims, what else did you expect?*");
        }

        public void Enrage()
        {
            Console.WriteLine("Though it is unable to express itself, in a mind where nothingness exists, nothingness is able to cease and be replaced by hatred for the extraterrestrial object which, ever so often, is tapping on the outer edges of the world.");
        }
    }
}
