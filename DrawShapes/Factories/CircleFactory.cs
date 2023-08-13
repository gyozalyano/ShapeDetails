using DrawShapes.CustomShapes;
using DrawShapes.UserInputs;

namespace DrawShapes.Factories;

public class CircleFactory : ShapeFactory
{
    public override IShape MakeShape()
    {
        var userInput = new UserInput();
        return new Circle(userInput);
    }
}