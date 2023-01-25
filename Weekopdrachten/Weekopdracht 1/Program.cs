using System;
using System.Collections.Generic;
using System.Linq;
using Weekopdracht_1__Dierenwinkel_.Models;

namespace Weekopdracht_1__Dierenwinkel_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> allAnimals = new List<Animal>
            {
                new Bird { Variety = "Huismus", Weight = 28, Price = 50, Bought = true },
                new Dog { Variety = "Golden Retriever", Weight = 32000, Price = 1200, Bought = true },
                new Fish { Variety = "Goudvis", Weight = 270, Price = 30, Bought = true }
            };

            foreach (Animal animal in allAnimals)
            {
                // Doormiddel van de inheritance weet ik zeker dat alle dieren een MakeSound()
                animal.MakeSound();
                Console.WriteLine($"I am a {animal.Variety}, I weigh {animal.Weight} and I cost {animal.Price} euros");

            }

            int totalPrice = allAnimals.Sum(Price => Price.Price);
            double totalWeight = allAnimals.Sum(Weight => Weight.Weight);

            Console.WriteLine($"The price of all animals combined is {totalPrice} euros");
            Console.WriteLine($"The weight of all animals combined is {totalWeight / 1000} kg");

            foreach(Animal animal in allAnimals)
            {
                if(animal.Bought)
                {
                    if(animal.GetType() == typeof(Bird))
                    {
                        ((Bird)animal).FlyLikeTheWind();
                    }

                    else if(animal.GetType() == typeof(Dog))
                    {
                        ((Dog)animal).RunLikeTheWind();
                    }

                    else if (animal.GetType() == typeof(Fish))
                    {
                        ((Fish)animal).Enrage();
                    }
                }
            }

            List<ISellable> sellableObjects = new List<ISellable>();
            sellableObjects.Add(new Food());
            sellableObjects.Add(new Toy());
      

            foreach(ISellable sellableObject in sellableObjects)
            {
                /* Omdat er een interface gebruikt wordt hoeft er geen hierarchie te zijn om toch gebruik maken van polymorfisme
                 * Hier weer hetzelfde geval als de functie MakeSound() hierboven, omdat ik weet dat er bij alle sellable objects
                 * een Sell() method is en die kan ik dus aanspreken test
                 */
                sellableObject.Sell();
           
            }
        }
    }
}
