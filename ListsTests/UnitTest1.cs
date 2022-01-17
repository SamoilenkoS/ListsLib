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
    }
}