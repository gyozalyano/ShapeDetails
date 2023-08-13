namespace DrawShapes.Factories;

public class MainFactory
{
    public static ShapeFactory? GetShapeFactory(string? userInput)
    {
        switch (userInput)
        {
            case "1":
                return new EllipseFactory();
            case "2":
                return new CircleFactory();
            case "3":
                return new RectangleFactory();
            case "4":
                return new SquareFactory();
            case "5":
                return new TextBookFactory();
            default:
                return null;
        }
    }
}