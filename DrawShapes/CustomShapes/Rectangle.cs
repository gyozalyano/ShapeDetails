using DrawShapes.UserInputs;

namespace DrawShapes.CustomShapes;

public sealed class Rectangle : IShape
{
    private const string Name = nameof(Rectangle);
    private double Width { get; set; }
    private double Height { get; set; }
    private double XCoordinate { get; set; }
    private double YCoordinate { get; set; }

    #region Public Instance Constructors

    public Rectangle(IUserInput userInput)
    {
        SetWidth(userInput);
        SetHeight(userInput);
        SetXCoordinate(userInput);
        SetYCoordinate(userInput);
    }

    #endregion

    #region Internal Instance Methods

    private void SetWidth(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide Width For Rectangle");
            var getInput = userInput.GetInput();

            if (InputValidation.IsPositiveNumber(getInput))
            {
                Width = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetHeight(IUserInput userInput)
    {
        Console.WriteLine("Provide Height For Rectangle");
        var getInput = userInput.GetInput();

        if (InputValidation.IsPositiveNumber(getInput))
        {
            Height = Convert.ToDouble(getInput);
            return;
        }

        Console.WriteLine("Incorrect Value.");
        SetHeight(userInput);
    }

    private void SetXCoordinate(IUserInput userInput)
    {
        Console.WriteLine("Provide The X Coordinate For Rectangle");
        var getInput = userInput.GetInput();

        if (InputValidation.IsNonNegativeNumber(getInput))
        {
            XCoordinate = Convert.ToDouble(getInput);
            return;
        }

        Console.WriteLine("Incorrect Value.");
        SetXCoordinate(userInput);
    }

    private void SetYCoordinate(IUserInput userInput)
    {
        Console.WriteLine("Provide The Y Coordinate For Rectangle");
        var getInput = userInput.GetInput();

        if (InputValidation.IsNonNegativeNumber(getInput))
        {
            YCoordinate = Convert.ToDouble(getInput);
            return;
        }

        Console.WriteLine("Incorrect Value.");
        SetYCoordinate(userInput);
    }
    
    #endregion

    #region Public Instance Methods

    public string PrintShapeDetails()
    {
        Console.WriteLine("You Have Requested to Draw This Shape");
        var details = string.Join(" ", Name, $"(" + XCoordinate, ",", YCoordinate + $")",
            "Width =", Width, "Height =", Height);
        Console.WriteLine(details);
        return details;
    }

    #endregion
}