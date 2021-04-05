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
                LeftFibonacciLimit = GetFibonacciValue(leftFibonacciLimit, Constant.FIBONACCI_LEFT_LIMIT),
                RightFibonacciLimit = GetFibonacciValue(rightFibonacciLimit, Constant.FIBONACCI_RIGHT_LIMIT)
            };

            bool rightData = false;

                while (!rightData)
                {
                    if (!_validArguments.RightLimitGreater(fibonacciParameters.LeftFibonacciLimit, fibonacciParameters.RightFibonacciLimit))
                    {
                        _printer.WriteLine(Constant.RIGHT_SHOULD_BE_GREATER);

                        _printer.Write(string.Format(Constant.ENTER_PROMPT, Constant.FIBONACCI_LEFT_LIMIT));
                        fibonacciParameters.LeftFibonacciLimit = GetFibonacciValue(_printer.ReadLine(), Constant.FIBONACCI_LEFT_LIMIT);

                        _printer.Write(string.Format(Constant.ENTER_PROMPT, Constant.FIBONACCI_RIGHT_LIMIT));
                        fibonacciParameters.RightFibonacciLimit = GetFibonacciValue(_printer.ReadLine(), Constant.FIBONACCI_RIGHT_LIMIT);

                        continue;
                    }

                    rightData = true;
                }

            return fibonacciParameters;
        }

        private int GetFibonacciValue(string fibonacciNumber, string valueName)
        {
            int result = -1;
            bool successFormat = false;
            Converter converterArgs = new Converter();
            
            while (!successFormat)
            {
                result = converterArgs.TryParseToInt(fibonacciNumber);

                if (result != -1)
                {
                    if (!_validArguments.CheckIntOnPositive(result, Constant.MAX_FIBONACCI_LIMIT))
                    {
                        _printer.WriteLine(Constant.WRONG_BOUNDARIES);
                        _printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                        fibonacciNumber = _printer.ReadLine();
                    }
                    else
                    {
                        successFormat = true;
                    }
                }
                else
                {
                    _printer.WriteLine(Constant.INT_WRONG_TYPE);
                    _printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                    fibonacciNumber = _printer.ReadLine();
                }
            }

            return result;
        }
    }
}
