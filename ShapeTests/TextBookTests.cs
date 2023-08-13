using DrawShapes.CustomShapes;
using NUnit.Framework;

namespace ShapeTests;

internal class TextBookTests
{
    [Test]
    public void PrintShapeDetails_Return_Correct_Value()
    {
        // Arrange
        var expected = "Textbook (5 , 5) Width = 5 Height = 5 Text = 5";
        var testInput = new ShapeTestSetUp();
        var textbook = new Textbook(testInput);

        // Act 
        var printedDetails = textbook.PrintShapeDetails();

        // Assert
        Assert.AreEqual(expected, printedDetails);
    }
}