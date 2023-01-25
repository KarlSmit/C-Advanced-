using Air_BnB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Weekopdracht3.ViewModels
{
    /// <summary>
    /// Main ViewModel for handling all the actions and starting the solver
    /// </summary>
    class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// The input numbers as a string for use in the textblock
        /// </summary>
        private string _inputNumbers;
        public string InputNumbers
        {
            get => _inputNumbers;
            set
            {
                _inputNumbers = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The answer which can only be one number
        /// </summary>
        private int _inputAnswer;
        public int InputAnswer
        {
            get => _inputAnswer;
            set
            {
                _inputAnswer = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The result text for the output calculation or potential exceptions
        /// </summary>
        private string _resultText;
        public string ResultText
        {
            get => _resultText;
            set
            {
                _resultText = value;
                OnPropertyChanged();
            }
        }

        public ICommand ExecuteSolverCommand { get; set; }

        public MainWindowViewModel()
        {
            ExecuteSolverCommand = new RelayCommand(Calculate);
        }

        /// <summary>
        /// Start the calculation with the provided numbers and result
        /// </summary>
        /// <param name="obj"></param>
        private void Calculate(object obj)
        {
            try
            {
                // Result (N)
                int inputResult = InputAnswer;

                // Get all the numbers from the string and turn it into a list of ints
                List<int> input = InputNumbers.Split(' ')
                                    .Where(stringValue => int.TryParse(stringValue, out _))
                                    .Select(int.Parse)
                                    .ToList();

                if (input.Count == 0)
                {
                    throw new Exception("No input elements were found");
                }

                // Start solving
                Solver solver = new Solver();
                bool found = solver.FindSolution(input, input.Count, inputResult);

                string solution;
                // Set solution if one is found
                if (found)
                {
                    solution = solver.Solution();
                }
                else // Redo based on the closest number if no solution is found
                {
                    // Get closest number of all calculations and run the algorithm again
                    int closestNumberToResult = solver.ResultList.OrderBy(item => Math.Abs(inputResult - item)).First();
                    found = solver.FindSolution(input, input.Count, closestNumberToResult);

                    solution = solver.Solution();
                }

                if (solution == "")
                {
                    throw new Exception("Invalid input/result.");
                }

                // Set the result
                ResultText = solution;
            } catch(Exception ex)
            {
                // Set the exception message in the result
                ResultText = ex.Message;
            }
        }
    }
}

