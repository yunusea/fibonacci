using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.FibonacciNumbers;
using DataLayer.FibonacciNumbers.DataContext;

namespace Tests.FibonacciNumbers
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void Test_Fibonacci_Input_2_Output_2()
        {
            var ResultNumber = FibonacciNumberArray.GetFibonacciNumbersByIndex(2);
            Assert.AreEqual(2, ResultNumber);
        }
        
        [TestMethod]
        public void Test_Fibonacci_Input_5_Output_8()
        {
            var ResultNumber = FibonacciNumberArray.GetFibonacciNumbersByIndex(5);
            Assert.AreEqual(8, ResultNumber);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_8_Output_34()
        {
            var ResultNumber = FibonacciNumberArray.GetFibonacciNumbersByIndex(8);
            Assert.AreEqual(34, ResultNumber);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_10_Output_89()
        {
            var ResultNumber = FibonacciNumberArray.GetFibonacciNumbersByIndex(10);
            Assert.AreEqual(89, ResultNumber);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_20_Output_10946()
        {
            var ResultNumber = FibonacciNumberArray.GetFibonacciNumbersByIndex(20);
            Assert.AreEqual(10946, ResultNumber);
        }
    }
}
