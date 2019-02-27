using NUnit.Framework;
using NasaApi;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDateFormate1()
        {
            var date = DateParser.ParseDate("11/30/88");
            Assert.AreEqual(new System.DateTime(1988, 11, 30), date);
        }

        [Test]
        public void TestDateFormate2()
        {
            var date = DateParser.ParseDate("June 2, 2018");
            Assert.AreEqual(new System.DateTime(2018, 6, 2), date);
        }

        [Test]
        public void TestDateFormate3()
        {
            var date = DateParser.ParseDate("Jul-13-2016");
            Assert.AreEqual(new System.DateTime(2016, 7, 13), date);
        }

        [Test]
        public void TestDateFormateFailed()
        {
            var date = DateParser.ParseDate("April 31, 2018");
            Assert.AreEqual(null, date);
        }

    }
}