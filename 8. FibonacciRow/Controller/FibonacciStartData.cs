using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Controller
{
    struct FibonacciStartData
    {
        private int leftFibonacciLimit;
        private int rightFibonacciLimit;

        public int LeftFibonacciLimit
        {
            get
            {
                return leftFibonacciLimit;
            }
            set
            {
                if (value >= 0)
                {
                    leftFibonacciLimit = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number should be greater than 0");
                }
            }
        }
        public int RightFibonacciLimit
        {
            get
            {
                return rightFibonacciLimit;
            }
            set
            {
                if (value >= 0)
                {
                    rightFibonacciLimit = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number should be greater than 0");
                }
            }
        }
    }
}
