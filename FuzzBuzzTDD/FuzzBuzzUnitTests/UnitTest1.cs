using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuzzBuzzTDD;

namespace FuzzBuzzUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsFuzz()
        {
            // arrange
            var FuzzBuzz = new FuzzBuzz();

            // act
            var fuzzResult = FuzzBuzz.FuzzBuzzLogic(3);
            var buzzResult = FuzzBuzz.FuzzBuzzLogic(5);
            var fuzzBuzzResult = FuzzBuzz.FuzzBuzzLogic(8);

            // asert
            Assert.AreEqual(fuzzResult, "fuzz");
            Assert.AreEqual(buzzResult, "buzz");
            Assert.AreNotEqual(fuzzBuzzResult, "fuzzbuzz");
        }
    }
}
