using DrawShapes.CustomShapes;
using DrawShapes.UserInputs;

namespace DrawShapes.Factories;

public class SquareFactory : ShapeFactory
{
    public override IShape MakeShape()
    {
        var userInput = new UserInput();
        return new Square(userInput);
    }
}