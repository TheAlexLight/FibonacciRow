using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FibonacciRow.Interfaces
{
    interface ISequence
    {
        IEnumerable<double> GetSequence();
    }
}
