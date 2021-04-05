using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Logic
{
    class FibonacciSequence
    {
        public FibonacciSequence(int leftSearchLimit, int rightSearchLimit)
        {
            _leftSearchLimit = leftSearchLimit;
            _rightSearchLimit = rightSearchLimit;
        }
        private readonly int _leftSearchLimit;
        private readonly int _rightSearchLimit;

        private readonly FibonacciNumbers numbers = new FibonacciNumbers();
        private FibonacciRange _range = new FibonacciRange();

        public int LeftSearchLimit { get { return _leftSearchLimit; } }
        public int RightSearchLimit { get { return _rightSearchLimit; } }

        public IEnumerable<double> GetFibonacciNumbers()
        {
            _range = numbers.GetClosestFibonacciRange(_leftSearchLimit);

            while (_range.LeftNumber < _rightSearchLimit)
            {
                if (!(_range.LeftNumber < _leftSearchLimit))
                {
                    yield return _range.LeftNumber;
                }
                GetNextFibonacci();
            }

            yield break;
        }

        private void GetNextFibonacci()
        {
            double tempNumber = _range.LeftNumber + _range.RightNumber;
            _range.LeftNumber = _range.RightNumber;
            _range.RightNumber = tempNumber;
        }
    }
}
