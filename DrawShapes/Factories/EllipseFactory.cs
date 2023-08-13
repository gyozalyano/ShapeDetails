using DrawShapes.CustomShapes;
using DrawShapes.UserInputs;

namespace DrawShapes.Factories;

public class EllipseFactory : ShapeFactory
{
    public override IShape MakeShape()
    {
        var userInput = new UserInput();
        return new Ellipse(userInput);
    }
}