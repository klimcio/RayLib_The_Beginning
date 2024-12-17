using Raylib_cs;
using System.Numerics;

public class GameplayPhase : IGamePhase
{
    private Protagonist protagonist;

    private Settings settings;
    private float rotation = 0f;

    public GameplayPhase(Settings settings)
    {
        this.settings = settings;

        protagonist = new Protagonist(settings.ScreenCenter);
    }

    public void Draw()
    {
        rotation += 0.2f;

        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("move the ball with arrow keys", 10, 10, 20, Color.DarkGray);

        Raylib.DrawCircle(settings.Width/5, 120, 35, Color.DarkBlue);
        Raylib.DrawCircleGradient(settings.Width / 5, 220, 60, Color.Green, Color.SkyBlue);
        Raylib.DrawCircleLines(settings.Width / 5, 340, 80, Color.DarkBlue);

        Raylib.DrawRectangle(settings.Width / 4 * 2 - 60, 100, 120, 60, Color.Red);
        Raylib.DrawRectangleGradientH(settings.Width / 4 * 2 - 90, 170, 180, 130, Color.Maroon, Color.Gold);
        Raylib.DrawRectangleLines(settings.Width / 4 * 2 - 40, 320, 80, 60, Color.Orange);

        Raylib.DrawTriangle(
            new Vector2(settings.Width / 4 * 3, 80), 
            new Vector2(settings.Width / 4 * 3 - 60, 150), 
            new Vector2(settings.Width / 4 * 3 + 60, 150), Color.Violet);

        Raylib.DrawTriangleLines(
            new Vector2(settings.Width / 4 * 3, 160),
            new Vector2(settings.Width / 4 * 3 - 20, 230),
            new Vector2(settings.Width / 4 * 3 + 20, 230), Color.DarkBlue);

        Raylib.DrawPoly(new Vector2(settings.Width / 4 * 3, 330), 6, 80, rotation, Color.Gold);
        Raylib.DrawPolyLines(new Vector2(settings.Width / 4 * 3, 330), 6, 90, rotation, Color.DarkBlue);
        Raylib.DrawPolyLinesEx(new Vector2(settings.Width / 4 * 3, 330), 6, 85, rotation, 6, Color.DarkBlue);

        //protagonist.Draw();
    }

    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.Right)) protagonist.MoveHorizontally(settings.BallSpeed);
        if (Raylib.IsKeyDown(KeyboardKey.Left)) protagonist.MoveHorizontally(-settings.BallSpeed);
        if (Raylib.IsKeyDown(KeyboardKey.Up)) protagonist.MoveVertically(-settings.BallSpeed);
        if (Raylib.IsKeyDown(KeyboardKey.Down)) protagonist.MoveVertically(settings.BallSpeed);

        if (Raylib.IsKeyPressed(KeyboardKey.Escape))
        {
            Program.currentScreen = GameScreen.ENDING;
        }
    }
}