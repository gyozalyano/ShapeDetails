using DrawShapes.CustomShapes;

namespace DrawShapes.Factories;

public abstract class ShapeFactory
{
    public abstract IShape MakeShape();

    internal IShape CreateShape()
    {
        IShape shape = MakeShape();

        return shape;
    }
}