using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.FibonacciNumbers
{
    public interface IFibonacciNumber
    {
        int GetFibonacciNumbersByIndex(int Index);
    }
}
