using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8.FibonacciRow.Logic;
using ConsolePrinterLibrary;

namespace _8.FibonacciRow.View
{
    class SequenceViewer
    {
        public SequenceViewer(FibonacciSequence sequence)
        {
            this.sequence = sequence;
        }

        FibonacciSequence sequence;
        ConsolePrinter printer = new ConsolePrinter();

        public void ShowFibonacciSequence()
        {
            IEnumerable<double> receivedSequence = sequence.GetFibonacciNumbers();

            var last = receivedSequence.Last();

            printer.Write(string.Format(Constant.FIBONACCI_RESULT,sequence.LeftSearchLimit,sequence.RightSearchLimit));

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
