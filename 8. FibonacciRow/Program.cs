using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _8.FibonacciRow.Logic;
using _8.FibonacciRow.View;

namespace _8.FibonacciRow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //if (args.Length != 2)
                //{
                //    throw new ArgumentException();
                //}

                FibonacciNumbers fibonacci = new FibonacciNumbers();

                FibonacciSequence sequence = new FibonacciSequence(364, 825);

               // IEnumerable<double> receivedSequence = sequence.GetFibonacciNumbers();

                SequenceViewer viewer = new SequenceViewer(sequence);

                viewer.ShowFibonacciSequence();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                Console.ReadKey();
                //Instruction

            }
        }
    }
}
