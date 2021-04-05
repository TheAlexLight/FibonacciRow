using _8.FibonacciRow.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Logic
{
    class FibonacciNumbers
    {
        private readonly double _pheta = 0.5 * (Math.Sqrt(5) + 1);

        public double Pheta 
        {
            get
            {
                return _pheta;
            } 
        }

        public FibonacciRange Range;

        public FibonacciRange GetClosestFibonacciNumbers(int number)
        {
            Range.LeftNumber = FibonacciRange(number, true);
            Range.RightNumber = FibonacciRange(number, false);

            return Range;
        }

        private double FibonacciBineFormula(int degree)
        {
            return (Math.Pow(_pheta, degree) - Math.Pow(1 - _pheta, degree)) / Math.Sqrt(5);
        }

        private int FibonacciLowerbound(double N, int minValue = 0, int maxValue = 1000)
        {
            int newPivot = (minValue + maxValue) / 2;
            if (minValue == newPivot)
            {
                return newPivot;
            }

            if (FibonacciBineFormula(newPivot) <= N)
            {
                return FibonacciLowerbound(N, newPivot, maxValue);
            }
            else
            {
                return FibonacciLowerbound(N, minValue, newPivot);
            }         
        }

        private double FibonacciRange(int number, bool isLeftNumber)
        {
            int leftBound = FibonacciLowerbound(number);

            if (isLeftNumber)
            {
                return FibonacciBineFormula(leftBound);
            }

            return FibonacciBineFormula(leftBound + 1);
        }
    }
}
