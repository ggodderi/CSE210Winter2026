using System.Runtime.Intrinsics;

class Vector2D
{
    private int X;
    private int Y;

    public Vector2D(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    private double VectorMagnitude => Math.Sqrt((X * X) + (Y * Y));

    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector2D operator -(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static bool operator <(Vector2D v1, Vector2D v2)
    {
        return v1.VectorMagnitude < v2.VectorMagnitude;
    }
    
    public static bool operator >(Vector2D v1, Vector2D v2)
    {
        return v1.VectorMagnitude >  v2.VectorMagnitude;
    }

    public static bool operator ==(Vector2D v1, Vector2D v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    public static bool operator !=(Vector2D v1, Vector2D v2)
    {
        return v1.X != v2.X && v1.Y != v2.Y;
    }

    public static Vector2D operator ++(Vector2D v1)
    {
        return new Vector2D(v1.X + 1, v1.Y + 1);
        // v1.X += 1;
        // v1.Y += 1;
        // return v1;
    }



    public string GetVectorDisplayString()
    {
        return $"x: {X}, y: {Y}";
    }
}