using ListsLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ListsTests
{
    [TestFixture(typeof(ArrayList<int>))]
    [TestFixture(typeof(ListsLibrary.LinkedList<int>))]
    public class Tests<T> where T : ListsLibrary.IList<int>, new()
    {
        ListsLibrary.IList<int> _list;

        [SetUp]
        public void Setup()
        {
            _list = new T();
        }

        [Test]
        public void Add_WhenCalled_ShouldAddElementToZeroIndex()
        {
            _list.Add(10);

            Assert.AreEqual(10, _list[0]);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        public void InitializerForArray_WhenArrayPassed_ShouldFillList
            (int[] sourceArray, int[] expectedArray)
        {
            _list = (ListsLibrary.IList<int>)Activator.CreateInstance(typeof(T), sourceArray);
            var instance = _list.CreateInstance(sourceArray);

            CollectionAssert.AreEqual(expectedArray, instance);
        }
    }
}