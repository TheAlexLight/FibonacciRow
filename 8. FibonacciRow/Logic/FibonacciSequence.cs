using _8.FibonacciRow.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Logic
{
    class FibonacciSequence: ISequence
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

        public int LeftSearchLimit => _leftSearchLimit;
        public int RightSearchLimit => _rightSearchLimit;

        public IEnumerable<double> GetSequence()
        {
            _range = numbers.GetClosestFibonacciNumbers(_leftSearchLimit);

            while (_range.LeftNumber < _rightSearchLimit)
            {
                if (!(_range.LeftNumber < _leftSearchLimit))
                {
                    yield return _range.LeftNumber;
                }
                GetNextNumber();
            }

            yield break;
        }

        private void GetNextNumber()
        {
            double tempNumber = _range.LeftNumber + _range.RightNumber;
            _range.LeftNumber = _range.RightNumber;
            _range.RightNumber = tempNumber;
        }
    }
}
