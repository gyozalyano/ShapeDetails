using DrawShapes.CustomShapes;
using NUnit.Framework;

namespace ShapeTests;

public class CircleTests
{
    [Test]
    public void PrintShapeDetails_Return_Correct_Value()
    {
        // Arrange
        var expected = "Circle (5 , 5) Size = 5";
        var testInput = new ShapeTestSetUp();
        var circle = new Circle(testInput);
            
        // Act 
        var printedDetails = circle.PrintShapeDetails();

        // Assert
        Assert.AreEqual(expected, printedDetails);
    }
}