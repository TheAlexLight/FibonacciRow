using ConsoleTaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _8.FibonacciRow.Controller;
using _8.FibonacciRow.Validation;
using _8.FibonacciRow.View;

namespace _8.FibonacciRow
{
    class FibonacciController
    {
        FibonacciStartData startData = new FibonacciStartData();
        readonly ConsolePrinter printer = new ConsolePrinter();
        Validator validArguments = new Validator();

        public FibonacciStartData CheckStartArguments(string leftFibonacciLimit, string rightFibonacciLimit)
        {
            try
            {
                startData.LeftFibonacciLimit = GetFibonacciValue(leftFibonacciLimit, Constant.FIBONACCI_LEFT_LIMIT);
                startData.RightFibonacciLimit = GetFibonacciValue(rightFibonacciLimit, Constant.FIBONACCI_RIGHT_LIMIT);

                bool rightData = false;

                while (!rightData)
                {
                    if (!validArguments.RightLimitGreater(startData.LeftFibonacciLimit,startData.RightFibonacciLimit))
                    {
                        printer.WriteLine(Constant.RIGHT_SHOULD_BE_GREATER);

                        printer.Write(string.Format(Constant.ENTER_PROMPT, Constant.FIBONACCI_LEFT_LIMIT));
                        startData.LeftFibonacciLimit = GetFibonacciValue(printer.ReadLine(), Constant.FIBONACCI_LEFT_LIMIT);

                        printer.Write(string.Format(Constant.ENTER_PROMPT, Constant.FIBONACCI_RIGHT_LIMIT));
                        startData.RightFibonacciLimit = GetFibonacciValue(printer.ReadLine(), Constant.FIBONACCI_RIGHT_LIMIT);

                        continue;
                    }

                    rightData = true;
                }
                
            }
            catch (ArgumentException ex)
            {
                printer.WriteLine(string.Format("{0}: {1}", Constant.EXCEPTION_OCCURED, ex.Message));
                throw;
            }

            return startData;
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
                    if (!validArguments.CheckIntOnPositive(result, FibonacciStartData.MAX_FIBONACCI_LIMIT))
                    {
                        printer.WriteLine(Constant.WRONG_BOUNDARIES);
                        printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                        fibonacciNumber = printer.ReadLine();
                    }
                    else
                    {
                        successFormat = true;
                    }
                }
                else
                {
                    printer.WriteLine(Constant.INT_WRONG_TYPE);
                    printer.Write(string.Format(Constant.ENTER_PROMPT, valueName));

                    fibonacciNumber = printer.ReadLine();
                }
            }

            return result;
        }
    }
}
