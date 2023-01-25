using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekopdracht_4.Models;

namespace Weekopdracht_4
{
    /// <summary>
    /// Main executor of the program
    /// </summary>
    public class Executor
    {
        // The stack
        private MyStack<float> _myStack = new MyStack<float>(100);

        /// <summary>
        /// Start the executor
        /// </summary>
        public void Start()
        {
            try
            {
                Console.WriteLine("Write 'stop' to stop entering numbers");
                string userInput = "";

                // Only stop asking for user input when the "stop" is input
                while (userInput != "stop")
                {
                    Console.Write("Input: ");
                    userInput = Console.ReadLine();

                    // Calculate the median
                    if (userInput == "mediaan")
                    {
                        GetMedian();
                        LogStack();
                        continue;
                    }

                    // Do a calculation
                    if(userInput == "+" || userInput == "/" || userInput == "-" || userInput == "*")
                    {
                        Calculate(userInput);
                        LogStack();
                        continue;
                    }

                    // Check if user input is a number
                    bool isNumber = int.TryParse(userInput, out int number);

                    // User input could be a letter or an invalid character
                    if (!isNumber)
                    {
                        // no valid input
                        Console.WriteLine("Invalid input");
                        continue;
                    }

                    // After all checks, add the number to the stack
                    _myStack.Push(number);
                    LogStack();
                }
            }
            catch(Exception ex)
            {
                // Log the exception
                Console.WriteLine(ex.Message);

                // Restart the executor so the application doesn't stop
                Start();
            }
        }

        /// <summary>
        /// Calculate first 2 numbers in the stack with the provided user input
        /// </summary>
        /// <param name="userInput">Could be +, -, / or *</param>
        private void Calculate(string userInput)
        {
            float firstNumber = _myStack.Pop();
            float secondNumber = _myStack.Pop();

            // A calculation based on the user input
            switch(userInput)
            {
                case "+":
                    _myStack.Push(firstNumber + secondNumber);
                    break;
                case "-":
                    _myStack.Push(firstNumber - secondNumber);
                    break;
                case "/":
                    _myStack.Push(firstNumber / secondNumber);
                    break;
                case "*":
                    _myStack.Push(firstNumber * secondNumber);
                    break;
            }
        }

        /// <summary>
        /// Get the stack as an array and log the array
        /// </summary>
        private void LogStack()
        {
            Console.WriteLine("Stack");

            var logArray = _myStack.ToArray().Reverse();
            foreach(int item in logArray)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Get median from Stack and place the median in the Stack
        /// </summary>
        private void GetMedian()
        {
            // The size of the stack
            var stackSize = _myStack.Count();

            // Create a new array from the stack
            float[] medianArray = new float[stackSize];

            // Get all data from the stack and add this to the array
            for(int stackCounter = 0; stackCounter < stackSize; stackCounter++)
            {
                medianArray[stackCounter] = _myStack.Pop();
            }

            // sort all numbers in an ascending order
            Array.Sort(medianArray);

            // put all the numbers at the start of the array instead of at the end
            Array.Reverse(medianArray);

            // get the middle index
            int mid = stackSize / 2;

            // get the middle number from the array
            float middlenumber = Convert.ToInt32(medianArray[mid]);
            float belowmiddlenumber = Convert.ToInt32(medianArray[mid - 1]);

            // calculate the median as a float for even array sizes
            float median = (stackSize % 2 != 0) ? middlenumber : (middlenumber + belowmiddlenumber) / 2;

            // Add the median to the stack
            _myStack.Push(median);
        }
    }
}
