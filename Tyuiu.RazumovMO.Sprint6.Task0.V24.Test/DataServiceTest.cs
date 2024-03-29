using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RazumovMO.Sprint6.Task0.V24.Lib;

namespace Tyuiu.RazumovMO.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class FindMaxTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FindMax fidmax = new FindMax();

            int[] costArray = new int[5] { 1, 2, 3, 4, 5 };

            int result = fidmax.FindMaxPrice(costArray);
            int wait = 5;

            Assert.AreEqual(wait, result);
        }
    }
}