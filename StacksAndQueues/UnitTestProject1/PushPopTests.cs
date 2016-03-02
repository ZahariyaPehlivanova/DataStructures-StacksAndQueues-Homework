namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _03.ArrayBasedClass;

    [TestClass]
    public class PushPopTests
    {
        [TestMethod]
        public void Push_Pop_Element()
        {
            var stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count);
            stack.Push(2);
            Assert.AreEqual(1, stack.Count);
            stack.Pop();
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Push_Pop_1000_Elements()
        {
            var nums = new ArrayStack<int>();
            Assert.AreEqual(0, nums.Count);

            for (int i = 0; i < 1001; i++)
            {
                nums.Push(i);
                Assert.AreEqual(i + 1, nums.Count);
            }
            for (int i = 0; i < 1001; i++)
            {
                Assert.AreEqual(1000 - i, nums.Pop());
                Assert.AreEqual(1000 - i, nums.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Pop_FromEmptyStack_ShouldThrow()
        {
            var stack = new ArrayStack<int>();
            stack.Pop();
        }

        [TestMethod]
        public void Push_Pop_WithInitialCapacity1()
        {
            var stack = new ArrayStack<int>(1);
            Assert.AreEqual(0, stack.Count);
            stack.Push(2);
            Assert.AreEqual(1, stack.Count);
            stack.Push(3);
            Assert.AreEqual(2, stack.Count);
            stack.Pop();
            Assert.AreEqual(1, stack.Count);
            stack.Pop();
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void To_Array()
        {
            var nums = new ArrayStack<int>();
            nums.Push(3);
            nums.Push(5);
            nums.Push(-2);
            nums.Push(7);
            int[] arrTest = { 7, -2, 5, 3 };
            CollectionAssert.AreEqual(arrTest, nums.ToArray());
        }

        [TestMethod]
        public void To_Array_Empty()
        {
            var dates = new ArrayStack<DateTime>();
            var arrTest = new DateTime[0];

            CollectionAssert.AreEqual(arrTest, dates.ToArray());
        }
    }
}
