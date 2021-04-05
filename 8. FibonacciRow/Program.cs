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

                FibonacciController controller = new FibonacciController();

                controller.ExecuteMainOperations(args[0], args[1]);

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
