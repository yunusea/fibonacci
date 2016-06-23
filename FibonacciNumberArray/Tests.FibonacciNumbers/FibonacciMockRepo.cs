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
        private int _result;

        public FibonacciMockRepo(int Result)
        {
            _result = Result;
        }

        public int GetFibonacciNumbersByIndex(int Index)
        {
            return _result;
        }
    }
}
