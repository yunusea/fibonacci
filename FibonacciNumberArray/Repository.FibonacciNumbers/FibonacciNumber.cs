using Contracts.FibonacciNumbers;
using DataLayer.FibonacciNumbers.DataContext;
using DataLayer.FibonacciNumbers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.FibonacciNumbers
{
    public class FibonacciNumber : IFibonacciNumber
    {
        private readonly FibonacciNumberDataContext db = new FibonacciNumberDataContext();

        public int GetFibonacciNumbersByIndex(int Index)
        {
            var IndexDbControl = db.Query.Where(x => x.Index == Index).FirstOrDefault();

            if (IndexDbControl == null)
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

                var entity = new Query()
                {
                    Index = Index,
                    ResultNumber = IndexInNumber,
                    Date = DateTime.Now
                };

                db.Query.Add(entity);
                db.SaveChanges();

                return IndexInNumber;
            }
            else
            {
                return IndexDbControl.ResultNumber;
            }
        }
    }
}
