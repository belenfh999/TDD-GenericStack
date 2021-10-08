using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericStack.Library;

namespace GenericStack.Tests
{
    [TestClass]
    public class GenericStacksTests
    {
        private GenericStack<int> int_stack;
        private GenericStack<string> string_stack;

        public GenericStacksTests()
        {
            int_stack = new GenericStack<int>();
            string_stack = new GenericStack<string>();
        }

        [TestMethod]
        public void CanPopOffItem()
        {
            int_stack.Push(100);
            Assert.AreEqual(100, int_stack.Pop());
        }

        [TestMethod]
        public void CanPopOff2Items()
        {
            int_stack.Push(100)
                     .Push(-4);
            Assert.AreEqual(-4, int_stack.Pop());
            Assert.AreEqual(100, int_stack.Pop());
        }

        [TestMethod]
        public void CanPopOff3Items()
        {
            string_stack.Push("foo")
                        .Push("bar")
                        .Push("test");
            Assert.AreEqual("test", string_stack.Pop());
            Assert.AreEqual("bar", string_stack.Pop());
            Assert.AreEqual("foo", string_stack.Pop());
        }

        [TestMethod]
        public void CanPopOff4Items()
        {
            string_stack.Push("foo")
                        .Push("bar")
                        .Push("test")
                        .Push("rrrr");
            Assert.AreEqual("rrrr", string_stack.Pop());
            Assert.AreEqual("test", string_stack.Pop());
            Assert.AreEqual("bar", string_stack.Pop());
            Assert.AreEqual("foo", string_stack.Pop());
        }

        [TestMethod]
        public void CanPopFromEmptyStack()
        {
            Assert.AreEqual(default(string), string_stack.Pop());
        }

        [TestMethod]
        public void CantPushNullValue()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                string_stack.Push(default(string));
            });
        }
    }
}
