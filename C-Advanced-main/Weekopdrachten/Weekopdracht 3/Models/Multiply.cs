using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekopdracht3.Interfaces;

namespace Weekopdracht3.Models
{
    /// <summary>
    /// Operation for multiplying two numbers
    /// </summary>
    public class Multiply : IOperation
    {
        public int Evaluate(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;

            if (result <= numberOne || result <= numberTwo)
            {
                return 0;
            }
            else
            {
                return result;
            }
        }

        public string Symbol()
        {
            return "*";
        }
    }
}
