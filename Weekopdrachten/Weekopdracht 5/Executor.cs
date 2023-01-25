using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weekopdracht_5
{
    public class Executor
    {
        public void Start()
        {
            Console.Write("Voer het getal N in: ");
            var userInput = Console.ReadLine();
            
            var isNumber = int.TryParse(userInput, out int number);

            int maxLength = 0;
            if(isNumber)
            {
                maxLength = Convert.ToInt32(number * Math.Log(number));
            } else
            {
                throw new Exception("Invalid input value");
            }

            int[] deel1 = new int[maxLength];

            int start = 2;
            int end = start;

            int quarter = number / 4;

            long sumOfPrimeNumbers = 0;

            var tasks = new List<Task>();

            var test = CalculatePrimesInRange(2, 11);
            var index = 0;
            for (var taskCount = 0; taskCount < 4; taskCount++)
            {
                start = end;
                end += quarter;

                if(taskCount == 3) end = number;

                int loopStart = start;
                int loopEnd = end;

                Task task = Task<int[]>.Factory.StartNew(() => CalculatePrimesInRange(loopStart, loopEnd)).ContinueWith(primeNumbers =>
                {
                    foreach (int primeNumber in primeNumbers.Result)
                    {
                        deel1[index++] = primeNumber;

                        sumOfPrimeNumbers += primeNumber;
                    }
                });

                tasks.Add(task);
            }

            foreach(Task task in tasks)
            {
                task.Wait();
            }

            Console.WriteLine($"De som van de priemgetallen tussen 2 en {number} is: {sumOfPrimeNumbers}");
        }

        public int[] CalculatePrimesInRange(int start, int end)
        {
            List<int> primeNumbers = new List<int>();
            int primeCounter, primeModulus;
            for (var counter = start; counter <= end; counter++)
            {
                primeCounter = 2;
                primeModulus = 1;
                while (primeCounter < counter)
                {
                    if (counter % primeCounter == 0)
                    {
                        primeModulus = 0;
                        break;
                    }
                    primeCounter++;
                }
                if (primeModulus == 1)
                {

                    primeNumbers.Add(counter);
                }
            }

            return primeNumbers.ToArray();
        }
    }
}
