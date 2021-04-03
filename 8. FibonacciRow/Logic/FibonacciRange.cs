using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Logic
{
    struct FibonacciRange
    {
        private double leftNumber;
        private double rightNumber;

        public double LeftNumber 
        { 
            get 
            {
                return leftNumber;
            }
            set 
            {
                if (value >= 0)
                {
                    leftNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number should be greater than 0");
                }
            } 
        }
        public double RightNumber
        {
            get
            {
                return rightNumber;
            }
            set
            {
                if (value >= 0)
                {
                    rightNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number should be greater than 0");
                }
            }
        }
    }
}
