using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir İndeks Değeri Giriniz.");
            int indeks = int.Parse(Console.ReadLine());
            Console.WriteLine(Sayilar.Islem(indeks));
            Console.ReadKey();
        }
    }
}
