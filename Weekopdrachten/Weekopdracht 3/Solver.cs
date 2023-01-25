using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekopdracht3.Interfaces;
using Weekopdracht3.Models;

namespace Weekopdracht3
{
    class Solver
    {
        private static readonly List<IOperation> _operations = new List<IOperation>()
        {
            new Add(),
            new Subtract(),
            new Divide(),
            new Multiply(),
        };

        private List<string> _solution = new List<string>();

        public List<int> ResultList;

        public Solver()
        {
            ResultList = new List<int>();
        }

        public bool FindSolution(List<int> operands, int index, int total)
        {
            for (int operandCounter = 0; operandCounter < index; operandCounter++)
            {
                if (operands[operandCounter] == total)
                {
                    return true;
                }

                for (int operatorCounter = operandCounter + 1; operatorCounter < index; operatorCounter++)
                {
                    for (int operatorIndex = 0; operatorIndex < _operations.Count; operatorIndex++)
                    {
                        int result = _operations[operatorIndex].Evaluate(operands[operandCounter], operands[operatorCounter]);
                        ResultList.Add(result);

                        if (result == 0)
                            continue;

                        int saveOperand1 = operands[operandCounter];
                        int saveOperand2 = operands[operatorCounter];
                        operands[operandCounter] = result;
                        operands[operatorCounter] = operands[index - 1];

                        if (FindSolution(operands, index - 1, total))
                        {
                            _solution.Add(Math.Max(saveOperand1, saveOperand2) + " " +
                            _operations[operatorIndex].Symbol() + " " +
                            Math.Min(saveOperand1, saveOperand2) + " = " + result);
                            return true;
                        }

                        operands[operandCounter] = saveOperand1;
                        operands[operatorCounter] = saveOperand2;
                    }
                }
            }

            return false;
        }

        public string Solution()
        {
            string solution = "";
            for (int i = _solution.Count - 1; i >= 0; i--)
            {
                solution += $"{_solution[i]}" + Environment.NewLine;
            }

            return solution;
        }
    }
}
