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
            this.leftSearchLimit = leftSearchLimit;
            this.rightSearchLimit = rightSearchLimit;
        }

        private int leftSearchLimit;
        private int rightSearchLimit;

        private FibonacciNumbers numbers = new FibonacciNumbers();
        FibonacciRange range = new FibonacciRange();

        public IEnumerable<double> GetFibonacciNumbers()
        {
            range = numbers.GetClosestFibonacciRange(leftSearchLimit);

            while (range.LeftNumber < rightSearchLimit)
            {
                if (!(range.LeftNumber < leftSearchLimit))
                {
                    yield return range.LeftNumber;
                }
                GetNextFibonacci();
            }

            yield break;
        }

        private void GetNextFibonacci()
        {
            double tempNumber = range.LeftNumber + range.RightNumber;
            range.LeftNumber = range.RightNumber;
            range.RightNumber = tempNumber;
        }

    }


}
