using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Logic
{
    class FibonacciNumbers
    {
        private double pheta = 0.5 * (Math.Sqrt(5) + 1);

        FibonacciRange range = new FibonacciRange();

        //private double closestFibonacciLeft;
        //private int closestFibonacciRight;

        public double Pheta { get; }

        public FibonacciRange GetClosestFibonacciRange(int number)
        {
            range.LeftNumber = FibonacciRange(number, true);
            range.RightNumber = FibonacciRange(number, false);

            return range;
        }

        private double FibonacciBineFormula(int n)
        {
            return (Math.Pow(pheta, n) - Math.Pow(1 - pheta, n)) / Math.Sqrt(5);
        }

        private int FibonacciLowerbound(double N, int minValue = 0, int maxValue = 1000)
        {
            int newPivot = (minValue + maxValue) / 2;
            if (minValue == newPivot)
                return newPivot;

            if (FibonacciBineFormula(newPivot) <= N)
                return FibonacciLowerbound(N, newPivot, maxValue);
            else
                return FibonacciLowerbound(N, minValue, newPivot);
        }

        private double FibonacciRange(int number, bool isLeftNumber)
        {
            int lbound = FibonacciLowerbound(number);

            if (flag)
            {
                return FibonacciBineFormula(lbound);
            }

            return FibonacciBineFormula(lbound + 1);
        }
    }
}
