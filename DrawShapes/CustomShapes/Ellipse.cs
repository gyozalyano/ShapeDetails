using DrawShapes.UserInputs;

namespace DrawShapes.CustomShapes;

public sealed class Ellipse : IShape
{
    private const string Name = nameof(Ellipse);
    private double HorizontalDiameter { get; set; }
    private double VerticalDiameter { get; set; }
    private double XCoordinate { get; set; }
    private double YCoordinate { get; set; }

    #region Public Instance Constructors

    public Ellipse(IUserInput userInput)
    {
        SetVerticalDiameter(userInput);
        SetHorizontalDiameter(userInput);
        SetXCoordinate(userInput);
        SetYCoordinate(userInput);
    }

    #endregion

    #region Private Instance Methods

    private void SetVerticalDiameter(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide a Vertical Diameter For Ellipse");
            var getInput = userInput.GetInput();

            if (InputValidation.IsPositiveNumber(getInput))
            {
                VerticalDiameter = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetHorizontalDiameter(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide a Horizontal Diameter For Ellipse");
            var getInput = userInput.GetInput();

            if (InputValidation.IsNonNegativeNumber(getInput))
            {
                VerticalDiameter = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetXCoordinate(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide The X Coordinate For Ellipse Center");
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
            Console.WriteLine("Provide The Y Coordinate For Ellipse Center");
            var getInput = userInput.GetInput();

            if (InputValidation.IsPositiveNumber(getInput))
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
            "Horizontal Diameter =", HorizontalDiameter, "Vertical Diameter =", VerticalDiameter);
        Console.WriteLine(details);
        return details;
    }

    #endregion
}