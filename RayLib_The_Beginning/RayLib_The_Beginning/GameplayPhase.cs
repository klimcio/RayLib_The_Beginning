using Raylib_cs;
using System.Numerics;

public class Protagonist
{
    Vector2 ballPosition = new((float)Program.width / 2, (float)Program.height / 2);

    public void Draw()
        => Raylib.DrawCircleV(ballPosition, 50, Color.Maroon);

    public void MoveHorizontally(float newH)
        => ballPosition.X += newH;

    public void MoveVertically(float newH)
        => ballPosition.Y += newH;
}

public class GameplayPhase : IGamePhase
{
    Protagonist protagonist = new();

    public void Draw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("move the ball with arrow keys", 10, 10, 20, Color.DarkGray);

        protagonist.Draw();
    }

    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.Right)) protagonist.MoveHorizontally(2.0f);
        if (Raylib.IsKeyDown(KeyboardKey.Left)) protagonist.MoveHorizontally(-2.0f);
        if (Raylib.IsKeyDown(KeyboardKey.Up)) protagonist.MoveVertically(-2.0f);
        if (Raylib.IsKeyDown(KeyboardKey.Down)) protagonist.MoveVertically(2.0f);

        if (Raylib.IsKeyPressed(KeyboardKey.Escape))
        {
            Program.currentScreen = GameScreen.ENDING;
        }
    }
}