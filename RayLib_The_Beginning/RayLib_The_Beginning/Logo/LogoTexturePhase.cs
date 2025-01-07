using Raylib_cs;

public class LogoTexturePhase : IGamePhase
{
    private int frameCounter = 0;
    private Settings settings;
    private Texture2D logoTexture;

    public LogoTexturePhase(Settings settings)
    {
        this.settings = settings;
        logoTexture = Raylib.LoadTexture("assets/raylib_logo.png");
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

        Raylib.DrawTexture(logoTexture, settings.Width / 2 - logoTexture.Width / 2, settings.Height / 2 - logoTexture.Height / 2, Color.White);
    }

    public void Unload()
    {
        Raylib.UnloadTexture(logoTexture);
    }
}