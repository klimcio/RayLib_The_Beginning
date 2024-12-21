using Raylib_cs;
using System.Numerics;

public class GameplayPhase : IGamePhase
{
    Protagonist protagonist;
    Settings settings;
    float rotation = 0f;
    bool IsPause = false;
    int frameCounter = 0;
    Vector2 initialSpeed = new(5.0f, 4.0f);

    public GameplayPhase(Settings settings)
    {
        this.settings = settings;

        protagonist = new Protagonist(
            settings.ScreenCenter, 
            initialSpeed
        );
    }

    public void Draw()
    {
        rotation += 0.2f;

        Raylib.ClearBackground(Color.RayWhite);

        protagonist.Draw();

        if (IsPause && (frameCounter/30%2 == 0))
            Raylib.DrawText("paused", 350, 200, 30, Color.Gray);

        Raylib.DrawFPS(10, 10);
    }

    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Space)) IsPause = !IsPause;

        if (!IsPause)
        {
            // protagonist.Update();

            if (protagonist.CheckCollisionX(Raylib.GetScreenWidth())) initialSpeed.X *= -1.0f;
            if (protagonist.CheckCollisionY(Raylib.GetScreenHeight())) initialSpeed.Y *= -1.0f;

            protagonist.Update(initialSpeed);
        }
        else frameCounter++;

        // if (Raylib.IsKeyDown(KeyboardKey.Right)) protagonist.MoveHorizontally(settings.BallSpeed);
        // if (Raylib.IsKeyDown(KeyboardKey.Left)) protagonist.MoveHorizontally(-settings.BallSpeed);
        // if (Raylib.IsKeyDown(KeyboardKey.Up)) protagonist.MoveVertically(-settings.BallSpeed);
        // if (Raylib.IsKeyDown(KeyboardKey.Down)) protagonist.MoveVertically(settings.BallSpeed);

        // if (Raylib.IsKeyPressed(KeyboardKey.Escape))
        // {
        //     Program.currentScreen = GameScreen.ENDING;
        // }
    }
}