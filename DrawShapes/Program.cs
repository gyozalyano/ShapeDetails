using DrawShapes.Factories;
using DrawShapes.UserInputs;

namespace DrawShapes;

public class Program
{
    #region Private Methods

    private static bool ShouldDrawAgain()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Do You Want to Draw a Shapes? Type 1 for yes and 0 for no.");

            var userInput = Console.ReadLine();
            if (InputValidation.IsZeroOrOne(userInput))
            {
                return userInput == "1";
            }

            Console.WriteLine("Invalid Input. Try again.");
        }
    }

    private static void MakeShape()
    {
        var userInput = Console.ReadLine();
        var shapeFactory = MainFactory.GetShapeFactory(userInput);
        var shape = shapeFactory?.CreateShape();
        shape?.PrintShapeDetails();
    }

    private static void DecideShape()
    {
        Console.WriteLine("Choose Which Shape To Draw");
        Console.WriteLine("Type 1 for Ellipse");
        Console.WriteLine("Type 2 for Circle");
        Console.WriteLine("Type 3 for Rectangle");
        Console.WriteLine("Type 4 for Square");
        Console.WriteLine("Type 5 for Textbook");
        Console.WriteLine();
    }

    private static void DrawALine()
    {
        var lines = new string('_', 80);
        Console.WriteLine(lines);
    }

    private static void Title()
    {
        DrawALine();
        Console.WriteLine("Requested Drawing");
        DrawALine();
    }

    #endregion

    #region Main

    private static void Main()
    {
        while (ShouldDrawAgain())
        {
            Title();
            DecideShape();
            MakeShape();
            DrawALine();
        }
    }

    #endregion
}