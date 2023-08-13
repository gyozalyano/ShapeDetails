using DrawShapes.CustomShapes;
using NUnit.Framework;

namespace ShapeTests;

internal class EllipseTests
{
    [Test]
    public void PrintShapeDetails_Return_Correct_Value()
    {
        // Arrange
        var expected = "Ellipse (5 , 5) Horizontal Diameter = 0 Vertical Diameter = 5";
        var testInput = new ShapeTestSetUp();
        var ellipse = new Ellipse(testInput);

        // Act 
        var printedDetails = ellipse.PrintShapeDetails();

        // Assert
        Assert.AreEqual(expected, printedDetails);
    }
}