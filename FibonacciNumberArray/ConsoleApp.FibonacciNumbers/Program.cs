using Business.FibonacciNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir İndeks Değeri Giriniz.");
            int Index = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumberArray.GetFibonacciNumbersByIndex(Index));
            Console.ReadKey();
        }
    }
}
