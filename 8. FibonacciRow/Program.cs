﻿using _8.FibonacciRow.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                IEnumerable<double> numbers = sequence.GetFibonacciNumbers();

                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }

                //Stopwatch stopwatch = new Stopwatch();

                //stopwatch.Start();
                //fibonacci.GetClosestFibonacciRange(20);
                //stopwatch.Stop();

                //Console.WriteLine("Потрачено тактов на выполнение: " + stopwatch.ElapsedTicks);

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
