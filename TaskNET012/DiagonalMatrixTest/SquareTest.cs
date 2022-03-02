using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskNET012;

namespace DiagonalMatrixTest
{
    [TestClass]
    public class SquareTest
    {
        SquareMatrix<int> Square = new SquareMatrix<int>(3);
        [TestMethod]
        public void CheckIndexerAreEqual()
        {
            var result = Square[0, 0] = 5;
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void CheckIndexerAreNotEqual()
        {
            var result = Square[0, 0] = 5;
            Assert.AreNotEqual(4, result);
        }
        [TestMethod]
        public void CheckValueIsNotNull()
        {
            try
            {
                var result = Square[0, 0] = 0;
                Assert.IsNotNull(result);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        [TestMethod]
        public void CheckReferenceEquals()
        {
            var result = Square[0, 0] = 0;
            Assert.ReferenceEquals(0, result);
        }
        [TestMethod]
        public void CheckReferenceEqual()
        {
            var result = Square[0, 0] = 0;
            Assert.ReferenceEquals(0, result);
        }
    }
}
