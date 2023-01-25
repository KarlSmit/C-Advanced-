using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekopdracht3.Interfaces;

namespace Weekopdracht3.Models
{
    /// <summary>
    /// Operation for subtracting two numbers.
    /// </summary>
    public class Subtract : IOperation
    {
        public int Evaluate(int numberOne, int numberTwo)
        {
            if (numberOne < numberTwo)
            {
                return numberTwo - numberOne;
            }
            else
            {
                return numberOne - numberTwo;
            }
        }

        public string Symbol()
        {
            return "-";
        }
    }
}