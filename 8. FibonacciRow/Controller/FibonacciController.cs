using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _8.FibonacciRow.Controller;
using _8.FibonacciRow.Logic;
using _8.FibonacciRow.Validation;
using _8.FibonacciRow.View;
using ConsoleTaskLibrary;

namespace _8.FibonacciRow
{
    class FibonacciController
    {
        private readonly ConsolePrinter _printer = new ConsolePrinter();
        private readonly Validator _validArguments = new Validator();

        public void ExecuteMainOperations(string leftFibonacciLimit, string rightFibonacciLimit)
        {
            try
            {
                FibonacciStartData _startData;

                _startData = CheckStartArguments(leftFibonacciLimit, rightFibonacciLimit);

                FibonacciSequence sequence = new FibonacciSequence(_startData.LeftFibonacciLimit, _startData.RightFibonacciLimit);

                SequenceViewer viewer = new SequenceViewer(sequence);

                viewer.ShowFibonacciSequence();
            }
            catch (ArgumentException ex)
            {
                _printer.WriteLine(string.Format("{0}: {1}", Constant.EXCEPTION_OCCURED, ex.Message));
                throw;
            }
        }

        public FibonacciStartData CheckStartArguments(string leftFibonacciLimit, string rightFibonacciLimit)
        {
            FibonacciStartData fibonacciParameters = new FibonacciStartData
            {
                LeftFibonacciLimit = GetFibonacciValue(leftFibonacciLimit),
                RightFibonacciLimit = GetFibonacciValue(rightFibonacciLimit)
            };

            if (!_validArguments.RightLimitGreater(fibonacciParameters.LeftFibonacciLimit, fibonacciParameters.RightFibonacciLimit))
            {
                _printer.WriteLine(Constant.RIGHT_SHOULD_BE_GREATER);
                _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT),
                    string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT));

                Environment.Exit(-1);
            }

            return fibonacciParameters;
        }

        private int GetFibonacciValue(string fibonacciNumber)
        {
            Converter converterArgs = new Converter();

            int result = converterArgs.TryParseToInt(fibonacciNumber);

            if (result != -1)
            {
                if (!_validArguments.CheckIntOnPositive(result, Constant.MAX_FIBONACCI_LIMIT))
                {
                    _printer.WriteLine(Constant.WRONG_BOUNDARIES);
                    _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT),
                        string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT));

                    Environment.Exit(-1);
                }
            }
            else
            {
                _printer.WriteLine(Constant.INT_WRONG_TYPE);
                _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT),
                    string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT));

                Environment.Exit(-1);
            }

            return result;
        }
    }
}
