using NUnit.Framework;

namespace SimpleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2, 3)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 4)]
        public void Test1(int a, int b, int expectedResult)
        {
            //Arrange
            int result = 0;

            //Act
            result = a + b;

            //Assert
            Assert.AreEqual(expectedResult, result, $"a={a} and b={b} calculated incorrectly");
        }
    }
}