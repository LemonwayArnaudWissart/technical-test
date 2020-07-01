using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceCore;

namespace UnitTests
{
    [TestClass]
    public class UnitTestFibonacci
    {
        [TestMethod]
        public void TestFibonacci1()
        {
            //Fibonacci(1) must return 1
            Assert.AreEqual(1, Core.Fibonacci(1));
        }
        [TestMethod]
        public void TestFibonacci2()
        {
            //Fibonacci(2) must return 1
            Assert.AreEqual(1, Core.Fibonacci(2));
        }
        [TestMethod]
        public void TestFibonacci3()
        {
            //Fibonacci(3) must return 2
            Assert.AreEqual(2, Core.Fibonacci(3));
        }
        [TestMethod]
        public void TestFibonacci4()
        {
            //Fibonacci(4) must return 3
            Assert.AreEqual(3, Core.Fibonacci(4));
        }
        [TestMethod]
        public void TestFibonacci5()
        {
            //Fibonacci(5) must return 5
            Assert.AreEqual(5, Core.Fibonacci(5));
        }
        [TestMethod]
        public void TestFibonacci6()
        {
            //Fibonacci(6) must return 8
            Assert.AreEqual(8, Core.Fibonacci(6));
        }
    }
}
