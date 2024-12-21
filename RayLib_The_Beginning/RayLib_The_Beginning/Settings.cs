using System.Numerics;

public class Settings
{
    // public float BallSpeed { get; set; } = 2.0f;
    public int Width { get; set; } = 800;
    public int Height { get; set; } = 450;
    public int TargetFPS { get; set; } = 60;

    public Vector2 ScreenCenter
        => new(Width / 2, Height / 2);
}
