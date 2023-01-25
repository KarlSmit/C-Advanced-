using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht_1__Dierenwinkel_.Models
{
    /*polymorfisme kan ook bereikt worden zonder "abstract" toe te voegen. Echter is het toevoegen van abstract wel handig
     * wanneer je de base class iets abstracts is waar je nooit iets van kan maken.
     * Ik kan bijvoorbeeld wel een dog of een fish uit een animal kunnen halen maar geen object aninal uit een animal.
     */
    abstract public class Animal
    {
        // Alle animals die er in de dierenwinkel te vinden zijn beschikken over deze properties en methods.
        public int Price { get; set; }
        public int Weight { get; set; }
        public string Variety { get; set; }

        public bool Bought { get; set; }
        

        public virtual void MakeSound()
        {
      
        }
    }
}
