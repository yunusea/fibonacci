using Contracts.FibonacciNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.FibonacciNumbers
{
    public class FibonacciMockRepo : IFibonacciNumber
    {
        public int GetFibonacciNumbersByIndex(int Index)
        {
            return 2;
        }
    }
}
