using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Logic
{
    class FibonacciSequence : IEnumerable
    {
        public FibonacciSequence(FibonacciNumbers numbers)
        {
            this.numbers = numbers;
        }

        FibonacciNumbers numbers;

        //public 



        public IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }


}
