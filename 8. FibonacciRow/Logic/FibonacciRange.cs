using _8.FibonacciRow.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Logic
{
    struct FibonacciRange
    {
        private double _leftNumber;
        private double _rightNumber;

        public double LeftNumber 
        { 
            get 
            {
                return _leftNumber;
            }
            set 
            {
                if (value >= 0)
                {
                    _leftNumber = value;
                }
                else
                {
                    throw new ArgumentException(Constant.NEGATIVE_NUMBER);
                }
            } 
        }
        public double RightNumber
        {
            get
            {
                return _rightNumber;
            }
            set
            {
                if (value >= 0)
                {
                    _rightNumber = value;
                }
                else
                {
                    throw new ArgumentException(Constant.NEGATIVE_NUMBER);
                }
            }
        }
    }
}
