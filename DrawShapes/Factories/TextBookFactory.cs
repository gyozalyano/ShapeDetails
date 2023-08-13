using DrawShapes.CustomShapes;
using DrawShapes.UserInputs;

namespace DrawShapes.Factories;

public class TextBookFactory : ShapeFactory
{
    public override IShape MakeShape()
    {
        var userInput = new UserInput();
        return new Textbook(userInput);
    }
}