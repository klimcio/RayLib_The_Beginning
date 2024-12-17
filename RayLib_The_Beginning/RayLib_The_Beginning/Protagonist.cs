using Raylib_cs;
using RayLib_The_Beginning;
using System.Numerics;

public class Protagonist
{
    Vector2 ballPosition;

    public Protagonist(Vector2 screenCenter)
    {
        ballPosition = screenCenter;
    }

    public void Draw()
        => ballPosition.DrawCircle(50, Color.Maroon);

    public void MoveHorizontally(float newH)
        => ballPosition.X += newH;

    public void MoveVertically(float newH)
        => ballPosition.Y += newH;
}
