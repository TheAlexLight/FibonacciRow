using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _8.FibonacciRow.Logic;
using ConsoleTaskLibrary;

namespace _8.FibonacciRow.View
{
    class SequenceViewer
    {
        public SequenceViewer(FibonacciSequence sequence)
        {
            _sequence = sequence;
        }

        private readonly FibonacciSequence _sequence;
        private readonly ConsolePrinter _printer = new ConsolePrinter();

        public void ShowFibonacciSequence()
        {
            IEnumerable<double> receivedSequence = _sequence.GetFibonacciNumbers();

            var last = receivedSequence.Last();

            _printer.Write(string.Format(Constant.FIBONACCI_RESULT,_sequence.LeftSearchLimit,_sequence.RightSearchLimit));

            foreach (var number in receivedSequence)
            {
                if (!number.Equals(last))
                {
                    Console.Write(string.Format("{0}, ", number));
                }
                else
                {
                    Console.WriteLine(string.Format("{0}", number));
                }

            }
        }
    }
}
