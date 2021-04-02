using NUnit.Framework;

namespace NameGeneratorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            NameGenerator.Program _name = new NameGenerator.Program();
            string sonuc = _name.RandomName(5, 0, "male");

            Assert.AreEqual(sonuc, "Benjamin");

        }
    }
}