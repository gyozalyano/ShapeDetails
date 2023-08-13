using DrawShapes.UserInputs;

namespace DrawShapes.CustomShapes;

public sealed class Square : IShape
{
    private const string Name = nameof(Square);
    private double Width { get; set; }
    private double XCoordinate { get; set; }
    private double YCoordinate { get; set; }

    #region Public Instance Constructors

    public Square(IUserInput userInput)
    {
        SetWidth(userInput);
        SetXCoordinate(userInput);
        SetYCoordinate(userInput);
    }

    #endregion

    #region Private Instance Methods

    private void SetWidth(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide a Width for Square");
            var getInput = userInput.GetInput();

            if (InputValidation.IsPositiveNumber(getInput))
            {
                Width = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetXCoordinate(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide The X Coordinate For Square Center");
            var getInput = userInput.GetInput();

            if (InputValidation.IsNonNegativeNumber(getInput))
            {
                XCoordinate = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetYCoordinate(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide The Y Coordinate For Square Center");
            var getInput = userInput.GetInput();

            if (InputValidation.IsNonNegativeNumber(getInput))
            {
                YCoordinate = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    #endregion

    #region Public Instance Methods

    public string PrintShapeDetails()
    {
        Console.WriteLine("You Have Requested to Draw This Shape");
        var details = string.Join(" ", Name, $"(" + XCoordinate, ",", YCoordinate + $")",
            "Size =", Width);
        Console.WriteLine(details);
        return details;
    }

    #endregion
}