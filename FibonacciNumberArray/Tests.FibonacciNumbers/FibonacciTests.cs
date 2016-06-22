using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.FibonacciNumbers;
using DataLayer.FibonacciNumbers.DataContext;
using Contracts.FibonacciNumbers;

namespace Tests.FibonacciNumbers
{
    [TestClass]
    public class FibonacciTests
    {
        FibonacciNumberArray _fibonacciNumber;
        IFibonacciNumber _fiboNumber;

        [TestInitialize]
        public void Init()
        {
            _fiboNumber = new FibonacciMockRepo();
            _fibonacciNumber = new FibonacciNumberArray(_fiboNumber);
        }

        [TestMethod]
        public void CanFibonacciNumberGetByIndex()
        {
            var result = _fibonacciNumber.GetFibonacciNumbersByIndex(2);

            Assert.AreEqual(2, result);
        }

        //[TestMethod]
        //public void Test_Fibonacci_Input_2_Output_2()
        //{
        //    var ResultNumber = _fiboNumber.GetFibonacciNumbersByIndex(2);
        //    Assert.AreEqual(2, ResultNumber);
        //}

        //[TestMethod]
        //public void Test_Fibonacci_Input_5_Output_8()
        //{
        //    var ResultNumber = _fiboNumber.GetFibonacciNumbersByIndex(5);
        //    Assert.AreEqual(8, ResultNumber);
        //}

        //[TestMethod]
        //public void Test_Fibonacci_Input_8_Output_34()
        //{
        //    var ResultNumber = _fiboNumber.GetFibonacciNumbersByIndex(8);
        //    Assert.AreEqual(34, ResultNumber);
        //}

        //[TestMethod]
        //public void Test_Fibonacci_Input_10_Output_89()
        //{
        //    var ResultNumber = _fiboNumber.GetFibonacciNumbersByIndex(10);
        //    Assert.AreEqual(89, ResultNumber);
        //}

        //[TestMethod]
        //public void Test_Fibonacci_Input_20_Output_10946()
        //{
        //    var ResultNumber = _fiboNumber.GetFibonacciNumbersByIndex(20);
        //    Assert.AreEqual(10946, ResultNumber);
        //}
    }
}
