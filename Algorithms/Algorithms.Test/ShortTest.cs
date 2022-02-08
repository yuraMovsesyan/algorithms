using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Test
{
    [TestClass]
    public class ShortTest
    {
        [TestMethod]
        public void Bubble_NaturalFrom10To0_From0To10returned()
        {
            //arrenge
            List<int> x = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            List<int> expected = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //act
            List<int> actual = Short.Bubble(x);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}