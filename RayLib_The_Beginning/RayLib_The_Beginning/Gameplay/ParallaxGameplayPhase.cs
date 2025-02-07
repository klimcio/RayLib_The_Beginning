using Raylib_cs;

public class ParallaxGameplayPhase : IGamePhase
{
    Settings settings;
    bool IsPause = false;
    int frameCounter = 0;

    BackgroundTexture background;
    BackgroundTexture midground;
    BackgroundTexture foreground;

    public ParallaxGameplayPhase(Settings settings)
    {
        this.settings = settings;
        
        background = BackgroundTexture.Create("assets/backgrounds/cyberpunk_street_background.png", 0.1f);
        midground = BackgroundTexture.Create("assets/backgrounds/cyberpunk_street_midground.png", 0.5f);
        foreground = BackgroundTexture.Create("assets/backgrounds/cyberpunk_street_foreground.png", 1.0f);
    }

    public void Draw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        if (IsPause && (frameCounter / 30 % 2 == 0))
            Raylib.DrawText("paused", 350, 200, 30, Color.Gray);

        background.Draw();
        midground.Draw();
        foreground.Draw();

        //Raylib.DrawFPS(10, 10);
    }

    public void Unload()
    {
        background.Unload();
        midground.Unload();
        foreground.Unload();
    }

    public void Update()
    {
        background.Update();
        midground.Update();
        foreground.Update();

        if (Raylib.IsKeyPressed(KeyboardKey.Space)) IsPause = !IsPause;

        if (!IsPause)
        {
        }
    }
}
