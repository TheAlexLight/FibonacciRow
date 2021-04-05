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

        private FibonacciRange _range = new FibonacciRange();

        public double Pheta 
        {
            get
            {
                return _pheta;
            } 
        }

        public FibonacciRange Range 
        {
            get
            {
                return _range;
            }
            set
            {
                if (value.LeftNumber <= 0 && value.RightNumber <= 0)
                {
                    throw new ArgumentException(Constant.NEGATIVE_RANGE);
                }

                _range = value;
            }
        }

        public FibonacciRange GetClosestFibonacciRange(int number)
        {
            _range.LeftNumber = FibonacciRange(number, true);
            _range.RightNumber = FibonacciRange(number, false);

            return _range;
        }

        private double FibonacciBineFormula(int n)
        {
            return (Math.Pow(_pheta, n) - Math.Pow(1 - _pheta, n)) / Math.Sqrt(5);
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
