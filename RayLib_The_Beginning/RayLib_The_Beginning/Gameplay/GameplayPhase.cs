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

    public void Unload()
    {
    }

    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Space)) IsPause = !IsPause;

        if (!IsPause)
        {
            // protagonist.Update();

            if (protagonist.IsCollidingWithScreenBorderX()) initialSpeed.X *= -1.0f;
            if (protagonist.IsCollidingWithScreenBorderY()) initialSpeed.Y *= -1.0f;

            protagonist.Update(initialSpeed);
        }
    }
}
