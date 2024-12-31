using Raylib_cs;
using RayLib_The_Beginning;
using System.Numerics;

public interface IAmA2dBeing
{
    Vector2 position { get; }
    int radius { get; }
}

public class Protagonist : IAmA2dBeing
{
    public Vector2 position { get; private set; }

    public int radius => 20;

    Vector2 speed;

    public Protagonist(Vector2 screenCenter, Vector2 speedVector)
    {
        position = screenCenter;
        speed = speedVector;
    }

    public void Draw()
        => position.DrawCircle(radius, Color.Maroon);

    public void MoveHorizontally(float newH)
        => position = position + new Vector2(newH, 0.0f);

    public void MoveVertically(float newY)
        => position = position + new Vector2(0.0f, newY);

    internal void Update(Vector2? newSpeed)
    {
        if (newSpeed.HasValue)
            speed = newSpeed.Value;

        position = position + speed;
    }
}
