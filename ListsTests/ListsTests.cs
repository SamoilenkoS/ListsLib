using ListsLibrary;
using NUnit.Framework;

namespace ListsTests
{
    [TestFixture(typeof(ArrayList<int>))]
    [TestFixture(typeof(LinkedList<int>))]
    public class Tests<T> where T : IList<int>, new()
    {
        IList<int> _list;

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

        [Test]
        public void IndexerGet_WhenValidIndexInTheMiddle_ShouldReturnElement()
        {
            for (int i = 0; i < 5; i++)
            {
                _list.Add(i);
            }

            Assert.AreEqual(3, _list[3]);
        }

        [TestCase(new int[] { }, new int[] {}, 0, new int[] {})]
        [TestCase(new int[] { }, new[] { 1, 2, 3 }, 0, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 0, new[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 2, new[] { 1, 2, 4, 5, 6, 3 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
        public void AddByIndex_WhenIndexAndItemsAreValid_ShouldInsertItemsToPosition
            (int[] sourceArray, int[] arrayToInsert, int insertPosition, int[] expectedArray)
        {
            _list = _list.Initialize(sourceArray);

            _list.AddByIndex(insertPosition, arrayToInsert);

            CollectionAssert.AreEqual(expectedArray, _list);
        }

    }
}