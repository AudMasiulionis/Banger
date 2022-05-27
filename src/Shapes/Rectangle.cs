namespace Shapes;

public readonly struct Rectangle
{
    public int X { get; }
    public int Y { get; }
    public int Width { get; }
    public int Height { get; }

    public Rectangle(Point location, Size size)
    {
        X = location.X;
        Y = location.Y;
        Width = size.Width;
        Height = size.Height;
    }

    public bool IntersectsWith(Rectangle rect)
    {
        return rect.X < X + Width && X < rect.X + rect.Width &&
               rect.Y < Y + Height && Y < rect.Y + rect.Height;
    }
}