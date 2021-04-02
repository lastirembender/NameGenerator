using NUnit.Framework;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
         
        }

        [Test]
        public void RandomName()
        {
            NameGenerator.Program _name = new NameGenerator.Program();
            string sonuc = _name.RandomName(5, "female");

            Assert.AreEqual(sonuc, "Defne");
       
        }
    }
}