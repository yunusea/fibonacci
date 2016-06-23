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
        FibonacciNumberArray _fibonacci;
        IFibonacciNumber _fiboRepo;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void CanFibonacciNumberGetByIndex_Init()
        {
            switch (TestContext.TestName)
            {
                case "CanFibonacciNumberGetByIndex":
                    _fiboRepo = new FibonacciMockRepo(2);
                    _fibonacci = new FibonacciNumberArray(_fiboRepo);
                    break;

                case "Test_Fibonacci_Input_2_Output_2":
                    _fiboRepo = new FibonacciMockRepo(2);
                    _fibonacci = new FibonacciNumberArray(_fiboRepo);
                    break;

                case "Test_Fibonacci_Input_5_Output_8":
                    _fiboRepo = new FibonacciMockRepo(8);
                    _fibonacci = new FibonacciNumberArray(_fiboRepo);
                    break;

                case "Test_Fibonacci_Input_8_Output_34":
                    _fiboRepo = new FibonacciMockRepo(34);
                    _fibonacci = new FibonacciNumberArray(_fiboRepo);
                    break;

                case "Test_Fibonacci_Input_10_Output_89":
                    _fiboRepo = new FibonacciMockRepo(89);
                    _fibonacci = new FibonacciNumberArray(_fiboRepo);
                    break;

                case "Test_Fibonacci_Input_20_Output_10946":
                    _fiboRepo = new FibonacciMockRepo(10946);
                    _fibonacci = new FibonacciNumberArray(_fiboRepo);
                    break;

                default:
                    break;
            }
        }

        [TestMethod]
        public void CanFibonacciNumberGetByIndex()
        {
            var result = _fibonacci.GetFibonacciNumbersByIndex(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_2_Output_2()
        {
            var ResultNumber = _fibonacci.GetFibonacciNumbersByIndex(2);
            Assert.AreEqual(2, ResultNumber);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_5_Output_8()
        {
            var ResultNumber = _fibonacci.GetFibonacciNumbersByIndex(5);
            Assert.AreEqual(8, ResultNumber);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_8_Output_34()
        {
            var ResultNumber = _fibonacci.GetFibonacciNumbersByIndex(8);
            Assert.AreEqual(34, ResultNumber);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_10_Output_89()
        {
            var ResultNumber = _fibonacci.GetFibonacciNumbersByIndex(10);
            Assert.AreEqual(89, ResultNumber);
        }

        [TestMethod]
        public void Test_Fibonacci_Input_20_Output_10946()
        {
            var ResultNumber = _fibonacci.GetFibonacciNumbersByIndex(20);
            Assert.AreEqual(10946, ResultNumber);
        }
    }
}
