namespace DrawShapes.UserInputs;

internal class UserInput : IUserInput
{
    public string? GetInput()
    {
        return Console.ReadLine();
    }
}