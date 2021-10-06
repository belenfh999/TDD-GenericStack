using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericStack.Library;

namespace GenericStack.Tests
{
    [TestClass]
    public class GenericStacksTests
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var g_stack = new GenericStack<int>();
            g_stack.Push(100);
            Assert.AreEqual(100, g_stack.Pop());
        }
    }
}
