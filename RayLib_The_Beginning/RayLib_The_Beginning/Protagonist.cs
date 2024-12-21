using Raylib_cs;
using RayLib_The_Beginning;
using System.Numerics;

public class Protagonist
{
    Vector2 position;
    Vector2 speed;
    int radius = 20;

    public Protagonist(Vector2 screenCenter, Vector2 speedVector)
    {
        position = screenCenter;
        speed = speedVector;
    }

    public void Draw()
        => position.DrawCircle(radius, Color.Maroon);

    public void MoveHorizontally(float newH)
        => position.X += newH;

    public void MoveVertically(float newH)
        => position.Y += newH;

    internal bool CheckCollisionX(int screenWidth) 
        => (position.X >= (screenWidth - radius)) || (position.X <= radius);

    internal bool CheckCollisionY(int screenHeight) 
        => (position.Y >= (screenHeight - radius)) || (position.Y <= radius);

    internal void Update(Vector2? newSpeed)
    {
        if (newSpeed.HasValue)
            speed = newSpeed.Value;

        position.X += speed.X;
        position.Y += speed.Y;
    }
}
