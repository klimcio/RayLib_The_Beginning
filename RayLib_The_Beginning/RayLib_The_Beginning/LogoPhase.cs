using Raylib_cs;

public class LogoPhase : IGamePhase
{
    private int frameCounter = 0;
    private Settings settings;

    public LogoPhase(Settings settings)
    {
        this.settings = settings;
    }

    public void Update()
    {
        frameCounter++;
        if (frameCounter > 120)
        {
            Program.currentScreen = GameScreen.TITLE;
        }
    }

    public void Draw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("LOGO SCREEN", 20, 20, 40, Color.Black);
    }
}