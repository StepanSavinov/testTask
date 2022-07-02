using Test;

namespace UnitTests
{
    public class FigureHelperTests
    {
        private FigureHelper _sut;

        [OneTimeSetUp]
        public void Setup()
        {
            _sut = new FigureHelper();
        }

        [Test]
        [TestCase(5)]
        [TestCase(32)]
        [TestCase(11)]
        [TestCase(37)]
        [TestCase(4.75)]
        [TestCase(2.74653)]
        [TestCase(99.464667863)]
        public void GetCircleArea_Success(double r)
        {
            // ARRANGE
            var radius = r;

            // ACT
            var actualArea = _sut.GetCircleArea(radius);
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            // ASSERT
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCase(-3)]
        [TestCase(-756)]
        [TestCase(-7.75456)]
        public void GetCircleArea_Failure(double r)
        {
            // ARRANGE
            var radius = r;

            // ACT
            

            // ASSERT
            Assert.Throws<ArgumentException>(() => _sut.GetCircleArea(radius));
        }

        [Test]
        [TestCase(5, 5, 5)]
        [TestCase(5, 4, 5)]
        [TestCase(5, 2, 5)]
        [TestCase(5, 1, 5)]
        [TestCase(5.765, 5.353, 5.1)]
        [TestCase(56773, 5467, 654.3553)]
        [TestCase(1234, 234.967890547, 9.982934892)]
        public void GetTriangleArea_Success(double a, double b, double c)
        {
            // ARRANGE
            var sideA = a;
            var sideB = b;
            var sideC = c;
            var p = (a + b + c) / 2;

            // ACT
            var actualArea = _sut.GetTriangleArea(sideA, sideB, sideC);
            var expectedArea = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            

            // ASSERT
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCase(5, 0, 5)]
        [TestCase(-3, 4, 5)]
        [TestCase(5, 2, -0.8934573)]
        [TestCase(-1, 0.23894, 5)]
        [TestCase(5.765, -0.353, 5.1)]
        [TestCase(56773, -5467, 654.3553)]
        [TestCase(-1234, 234.967890547, 9.982934892)]
        public void GetTriangleArea_Failure(double a, double b, double c)
        {
            // ARRANGE
            var sideA = a;
            var sideB = b;
            var sideC = c;

            // ACT


            // ASSERT
            Assert.Throws<ArgumentException>(() => _sut.GetTriangleArea(sideA, sideB, sideC));
        }
    }
}