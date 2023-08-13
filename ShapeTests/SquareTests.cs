using DrawShapes.CustomShapes;
using NUnit.Framework;

namespace ShapeTests;

internal class SquareTests
{
    [Test]
    public void PrintShapeDetails_Return_Correct_Value()
    {
        // Arrange
        var expected = "Square (5 , 5) Size = 5";
        var testInput = new ShapeTestSetUp();
        var square = new Square(testInput);

        // Act 
        var printedDetails = square.PrintShapeDetails();

        // Assert
        Assert.AreEqual(expected, printedDetails);
    }
}