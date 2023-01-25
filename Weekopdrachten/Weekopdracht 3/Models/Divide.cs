using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekopdracht3.Interfaces;

namespace Weekopdracht3.Models
{
    /// <summary>
    /// Operation for dividing two numbers
    /// </summary>
    public class Divide : IOperation
    {
        public int Evaluate(int numberOne, int numberTwo)
        {
            // Reverse calculations for number
            if (numberOne < numberTwo)
            {
                int saved = numberOne;
                numberOne = numberTwo;
                numberTwo = saved;
            }

            if (numberOne % numberTwo == 0)
            {
                return numberOne / numberTwo;
            }
            else
            {
                return 0;
            }
        }

        public string Symbol()
        {
            return "/";
        }
    }
}
