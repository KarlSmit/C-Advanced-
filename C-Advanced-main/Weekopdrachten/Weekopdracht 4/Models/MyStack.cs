using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht_4.Models
{
    /// <summary>
    /// Custom Stack implementation
    /// </summary>
    /// <typeparam name="T">The type of the MyStack</typeparam>
    public class MyStack<T>
    {
        // The length of the stack
        private int _stackLength;

        // Keeping track of all the data in the stack
        private T[] _internalArray;

        // The tracker for the amount of items in the stack
        private int _stackCounter = -1;

        public MyStack(int maxLength)
        {
            _stackLength = maxLength;
            // Create the internal array and set the length
            _internalArray = new T[_stackLength];
        }

        /// <summary>
        /// Place an item at the top of the stack
        /// </summary>
        /// <param name="item">The item to place at the top of the stack</param>
        public void Push(T item)
        {
            _internalArray[++_stackCounter] = item;
        }

        /// <summary>
        /// Remove the top item in the stack
        /// </summary>
        /// <returns>The top item in the array</returns>
        public T Pop()
        {
            // Save the item from the array in a variable
            T item = _internalArray[_stackCounter];

            // Set the item to the default value to remove it
            _internalArray[_stackCounter] = default;

            // Deduct the amount of items in the stack
            _stackCounter--;

            // Return the item
            return item;
        }

        /// <summary>
        /// Read the top item in the stack
        /// </summary>
        /// <returns>The top item in the stack</returns>
        public T Peek()
        {
            // Get the top item in the stack based on the stack counter
            T item = _internalArray[_stackCounter];

            return item;
        }

        /// <summary>
        /// Creates a new array from all the data in the stack
        /// </summary>
        /// <returns>A new array based on the stack</returns>
        public T[] ToArray()
        {
            var newArray = new T[_stackCounter + 1];
            for(int counter = 0; counter <= _stackCounter; counter++)
            {
                newArray[counter] = _internalArray[counter];
            }
            return newArray;
        }

        /// <summary>
        /// Get the total count of the stack
        /// </summary>
        /// <returns>The total count of the stack</returns>
        public int Count()
        {
            return _stackCounter + 1;
        }
    }
}
