using Business.FibonacciNumbers;
using Contracts.FibonacciNumbers;
using Repository.FibonacciNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.FibonacciNumbers
{
    public class Program
    {
        private readonly IFibonacciNumber _fibonacciNumber;

        public Program(IFibonacciNumber FibonacciNumber)
        {
            _fibonacciNumber = FibonacciNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bir İndeks Değeri Giriniz.");
            int Index = int.Parse(Console.ReadLine());
            Console.WriteLine(_fibonacciNumber.GetFibonacciNumbersByIndex(Index));
            Console.ReadKey();
        }
    }
}
