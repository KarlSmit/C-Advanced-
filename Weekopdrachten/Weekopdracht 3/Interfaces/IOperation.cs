using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht3.Interfaces
{
    /// <summary>
    /// Interface for a generic implementation of all arithmetic operations
    /// </summary>
    public interface IOperation
    {
        int Evaluate(int numberOne, int numberTwo);
        string Symbol();
    }
}
