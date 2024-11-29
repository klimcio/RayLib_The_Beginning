using Raylib_cs;
using System.Numerics;

public class GameplayPhase : IGamePhase
{
    Vector2 ballPosition = new((float)Program.width / 2, (float)Program.height / 2);

    public void Draw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("move the ball with arrow keys", 10, 10, 20, Color.DarkGray);

        Raylib.DrawCircleV(ballPosition, 50, Color.Maroon);
    }

    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.Right)) ballPosition.X += 2.0f;
        if (Raylib.IsKeyDown(KeyboardKey.Left)) ballPosition.X -= 2.0f;
        if (Raylib.IsKeyDown(KeyboardKey.Up)) ballPosition.Y -= 2.0f;
        if (Raylib.IsKeyDown(KeyboardKey.Down)) ballPosition.Y += 2.0f;

        if (Raylib.IsKeyPressed(KeyboardKey.Escape))
        {
            Program.currentScreen = GameScreen.ENDING;
        }
    }
}