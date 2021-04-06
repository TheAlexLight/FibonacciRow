using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _8.FibonacciRow.Controller;
using _8.FibonacciRow.Logic;
using _8.FibonacciRow.View;
using ConsoleTaskLibrary;

namespace _8.FibonacciRow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new ArgumentException();
                }

                FibonacciController controller = new FibonacciController();

                controller.ExecuteMainOperations(args[0], args[1]);

                Console.ReadKey();
            }
            catch (Exception)
            {
                ConsolePrinter _printer = new ConsolePrinter();
                _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT),
                        string.Format(Constant.SECOND_ARGUMENT, Constant.MAX_FIBONACCI_LIMIT));
            }
        }
    }
}
