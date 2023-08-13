using DrawShapes.UserInputs;

namespace ShapeTests;

internal class ShapeTestSetUp : IUserInput
{
    public string GetInput()
    {
        return "5";
    }
}