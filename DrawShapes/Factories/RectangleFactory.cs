using DrawShapes.CustomShapes;
using DrawShapes.UserInputs;

namespace DrawShapes.Factories;

public class RectangleFactory : ShapeFactory
{
    public override IShape MakeShape()
    {
        var userInput = new UserInput();
        return new Rectangle(userInput);
    }
}