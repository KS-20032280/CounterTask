using CounterTask;
using NUnit.Framework;

namespace TestCounterTask
{
    [TestFixture()]
    public class TestCounter
    {
        private Counter counter;

        [SetUp]
        public void Setup()
        { 
            counter = new Counter("Test Counter");
        }

        [Test]
        public void TestInitialization()
        {
            Assert.AreEqual(0, counter.Tick);
        }

        [Test]
        public void TestAddOneToCount()
        {
            counter.Increment();
            Assert.AreEqual(1, counter.Tick);
        }

        [Test]
        public void TestAddMultipleTimesToCount()
        {
            for(int i = 0; i < 10; i++)
            {
                counter.Increment();
            }
            Assert.AreEqual(10, counter.Tick);
        }

        [Test]
        public void TestReset()
        {
            //increment the counter first, then reset
            for(int i = 0; i < 10; i++)
            {
                counter.Increment();
            }
            //verify that counter actually increased
            Assert.AreEqual(10, counter.Tick);
            counter.Reset();
            Assert.AreEqual(0, counter.Tick);
        }
    }
}