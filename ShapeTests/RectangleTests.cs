using DrawShapes.CustomShapes;
using NUnit.Framework;

namespace ShapeTests
{
    internal class RectangleTests
    {
        [Test]
        public void PrintShapeDetails_Return_Correct_Value()
        {
            // Arrange
            var expected = "Rectangle (5 , 5) Width = 5 Height = 5";
            var testInput = new ShapeTestSetUp();
            var rectangle = new Rectangle(testInput);

            // Act 
            var printedDetails = rectangle.PrintShapeDetails();

            // Assert
            Assert.AreEqual(expected, printedDetails);
        }
    }
}
