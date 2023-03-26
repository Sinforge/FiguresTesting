using FiguresProject;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTriangle()
        {
            IFigure triangle = new Triangle(4, 3, 5);
            Assert.AreEqual(6, triangle.CalculateSquare());

        }

        [TestMethod]
        public void TestTriangle2()
        {
            IFigure triangle = new Triangle(2, 3, 4);
            Assert.AreEqual(2.904738, triangle.CalculateSquare(), 0.01);

        }

        [TestMethod]

        public void TestCircle() {
            IFigure circle = new Circle(5);
            Assert.AreEqual(78.5375, circle.CalculateSquare(), 0.01);
        }
    }
}