﻿using DrawShapes.UserInputs;

namespace DrawShapes.CustomShapes;

public sealed class Textbook : IShape
{
    private const string Name = nameof(Textbook);
    private double Width { get; set; }
    private double Height { get; set; }
    private double XCoordinate { get; set; }
    private double YCoordinate { get; set; }
    private string? Text { get; set; }

    #region Public Instance Constructors

    public Textbook(IUserInput userInput)
    {
        SetWidth(userInput);
        SetHeight(userInput);
        SetXCoordinate(userInput);
        SetYCoordinate(userInput);
        SetText(userInput);
    }

    #endregion

    #region Private Instance Methods

    private void SetWidth(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide a Width for Textbook");
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
        while (true)
        {
            Console.WriteLine("Provide a Height for Textbook");
            var getInput = userInput.GetInput();

            if (InputValidation.IsPositiveNumber(getInput))
            {
                Height = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetXCoordinate(IUserInput userInput)
    {
        while (true)
        {
            Console.WriteLine("Provide The X Coordinate For Textbook Center");
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
            Console.WriteLine("Provide The Y Coordinate For TextBook Center");
            var getInput = userInput.GetInput();

            if (InputValidation.IsNonNegativeNumber(getInput))
            {
                YCoordinate = Convert.ToDouble(getInput);
                return;
            }

            Console.WriteLine("Incorrect Value.");
        }
    }

    private void SetText(IUserInput userInput)
    {
        Console.WriteLine("Provide Text");
        Text = userInput.GetInput();
    }
    #endregion

    #region Public Instance Methods

    public string PrintShapeDetails()
    {
        Console.WriteLine("You Have Requested to Draw This Shape");
        var details = string.Join(" ", Name, $"(" + XCoordinate, ",", YCoordinate + $")",
            "Width =", Width, "Height =", Height, "Text =", Text);
        Console.WriteLine(details);
        return details;
    }

    #endregion
}