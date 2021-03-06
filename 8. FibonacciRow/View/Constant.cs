using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.View
{
    class Constant
    {
        public const int MAX_FIBONACCI_LIMIT = 1000000000;

        public const string FIBONACCI_RESULT = "Your Fibonacci sequence in range [{0}, {1}): ";
        public const string WRONG_BOUNDARIES = "Wrong number boundaries";
        //public const string ENTER_PROMPT = "Enter your {0}: ";
        public const string INT_WRONG_TYPE = "Type of data should be integer";
        //public const string FIBONACCI_LEFT_LIMIT = "left border";
        //public const string FIBONACCI_RIGHT_LIMIT = "right border";
        public const string EXCEPTION_OCCURED = "ERROR occured";
        public const string RIGHT_SHOULD_BE_GREATER = "Right border should be greater than left";
        public const string NEGATIVE_NUMBER = "Number should be greater than 0";
        public const string NEGATIVE_RANGE = "Numbers should be greater than 0";
        public const string INSTRUCTION = "Instruction of using: You should use 2 arguments:";
        public const string FIRST_ARGUMENT = "1 argument - Left border: Type - Integer(Greater or equal 0 and less than {0})";
        public const string SECOND_ARGUMENT = "2 argument - Height: Type - Integer(Greater than 0, greater than left border and less than {0})";
    }
}
