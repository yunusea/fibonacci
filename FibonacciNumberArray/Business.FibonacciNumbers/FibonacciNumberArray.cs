using Contracts.FibonacciNumbers;
using DataLayer.FibonacciNumbers.DataContext;
using DataLayer.FibonacciNumbers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FibonacciNumbers
{
    public class FibonacciNumberArray
    {
        IFibonacciNumber _fibonacciRepo;

        public FibonacciNumberArray(IFibonacciNumber FibonacciRepo)
        {
            _fibonacciRepo = FibonacciRepo;
        }

        public int GetFibonacciNumbersByIndex(int Index)
        {
            var x = _fibonacciRepo.GetFibonacciNumbersByIndex(Index);
            return x; 
        }
    }
}
