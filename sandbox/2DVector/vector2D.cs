
using System.Runtime.CompilerServices;

class Vector2D
{
    private int X;
    private int Y;

    public Vector2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetVector2DDisplayString()
    {
        return $"x: {X}, y: {Y}";
    }

    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector2D operator -(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static bool operator ==(Vector2D v1, Vector2D v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    public static bool operator !=(Vector2D v1, Vector2D v2)
    {
        // return !(v1 == v2);
        return v1.X != v2.X || v1.Y != v2.Y;
    }

    public override bool Equals(Object? v1)
    {
        return (v1 as Vector2D)?.X == X && (v1 as Vector2D)?.Y == Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}