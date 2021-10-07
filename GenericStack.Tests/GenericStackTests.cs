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

        [TestMethod]
        public void CanPopOff2Items()
        {
            var g_stack = new GenericStack<int>();
            g_stack.Push(100);
            g_stack.Push(-4);
            Assert.AreEqual(-4, g_stack.Pop());
            Assert.AreEqual(100, g_stack.Pop());
        }

        [TestMethod]
        public void CanPopOff3Items()
        {
            var g_stack = new GenericStack<string>();
            g_stack.Push("foo");
            g_stack.Push("bar");
            g_stack.Push("test");
            Assert.AreEqual("test", g_stack.Pop());
            Assert.AreEqual("bar", g_stack.Pop());
            Assert.AreEqual("foo", g_stack.Pop());
        }

        [TestMethod]
        public void CanPopOff4Items()
        {
            var g_stack = new GenericStack<string>();
            g_stack.Push("foo");
            g_stack.Push("bar");
            g_stack.Push("test");
            g_stack.Push("rrrr");
            Assert.AreEqual("rrrr", g_stack.Pop());
            Assert.AreEqual("test", g_stack.Pop());
            Assert.AreEqual("bar", g_stack.Pop());
            Assert.AreEqual("foo", g_stack.Pop());
        }
    }
}
