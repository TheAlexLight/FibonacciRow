using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Validation
{
    class Validator
    {
        public bool CheckIntOnPositive(int intToCheck)
        {
            return intToCheck > 0;
        }

        public bool CheckIntOnPositive(int intToCheck, int maxValue)
        {
            return (intToCheck > 0 && intToCheck <= maxValue);
        }

        public bool RightLimitGreater(int leftFibonacciLimit, int rightFibonacciImit)
        {
            return rightFibonacciImit > leftFibonacciLimit;
        }
    }
}
