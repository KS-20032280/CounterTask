using CounterTask;
using NUnit.Framework;

namespace TestCounterTask
{
    [TestFixture()]
    public class TestClock
    {
        private Clock clock;

        [SetUp]
        public void Setup()
        {
            clock = new Clock();
        }

        [Test]
        public void TestInitialization()
        {
            //should return 00:00:00
            Assert.AreEqual("00:00:00", clock.GetTimeAsString());
        }

        [Test]
        public void TestTickOnce()
        {
            clock.Tick();
            Assert.AreEqual("00:00:01", clock.GetTimeAsString());
        }

        [Test]
        public void TestIncrementMinutes()
        {
            for(int i = 0; i < 60; i++)
            {
                clock.Tick();
            }
            Assert.AreEqual("00:01:00", clock.GetTimeAsString());
        }

        [Test]
        public void TestIncrementHours()
        {
            for(int i = 0; i < 3600; i++)
            {
                clock.Tick();
            }
            Assert.AreEqual("01:00:00", clock.GetTimeAsString());
        }

        [Test]
        public void Test3DifferentNumbers()
        {
            for(int i = 0; i < 4589; i++)
            {
                clock.Tick();
            }
            Assert.AreEqual("01:16:29", clock.GetTimeAsString());
        }

        [Test]
        public void TestReset()
        {
            for(int i = 0; i < 300; i++)
            {
                clock.Tick();
            }
            //Test if the clock actually incremented
            Assert.AreEqual("00:05:00", clock.GetTimeAsString());

            clock.Reset();
            Assert.AreEqual("00:00:00", clock.GetTimeAsString());
        }
    }
}
