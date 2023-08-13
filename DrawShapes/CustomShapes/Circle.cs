using DrawShapes.UserInputs;

namespace DrawShapes.CustomShapes;

public sealed class Circle : IShape
{
    #region Private Instance Fields and Properties

    private const string Name = nameof(Circle);
    private double Diameter { get; set; }
    private double XCoordinate { get; set; }
    private double YCoordinate { get; set; }
    
    #endregion

    #region Public Instance Constructors

    public Circle(IUserInput userInput)
    {
        SetDiameter(userInput);
        SetXCoordinate(userInput);
        SetYCoordinate(userInput);
    }

    #endregion

    #region Private Instance Methods

    private void SetDiameter(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide Diameter For Circle");
            var getInput = userInput.GetInput();

            if (InputValidation.IsPositiveNumber(getInput))
            {
                Diameter = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetXCoordinate(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide The X Coordinate For Circle Center");
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
            Console.WriteLine("Provide The Y Coordinate For Circle Center");
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
        var details = string.Join(" ", Name, $"(" + XCoordinate, ",", YCoordinate + $")", "Size =", Diameter);
        Console.WriteLine(details);
        return details;
    }

    #endregion
}