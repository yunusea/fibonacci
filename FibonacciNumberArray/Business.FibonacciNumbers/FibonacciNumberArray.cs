using DataLayer.FibonacciNumbers.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FibonacciNumbers
{
    public class FibonacciNumberArray
    {
        public static int GetFibonacciNumbersByIndex(int Index)
        {
            int[] Numbers = new int[Index + 1];
            int Number = 1;
            int OldNumber = 0;
            int NewNumber = 1;
            for (int i = 0; i <= Index; i++)
            {
                Numbers[i] = Number;
                Number = OldNumber + NewNumber;
                OldNumber = NewNumber;
                NewNumber = Number;
            }
            int IndexInNumber = Numbers[Index];
            return IndexInNumber;
        }
    }
}
