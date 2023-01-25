using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht_1__Dierenwinkel_.Models
{
    // De Dog class inherant van de Animal class doormiddel van de ": Animal".
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void RunLikeTheWind()
        {
            Console.WriteLine("*Runs with an overwhelming feeling of joy, originated through love and care by its owners*");
        }
    }
}
