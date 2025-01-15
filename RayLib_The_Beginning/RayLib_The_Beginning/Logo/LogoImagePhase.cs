using Raylib_cs;

public class LogoImagePhase : IGamePhase
{
    private int frameCounter = 0;
    private Settings settings;
    //private Image logoImage;
    private Texture2D texture2D;

    public LogoImagePhase(Settings settings)
    {
        this.settings = settings;
        var logoImage = Raylib.LoadImage("assets/raylib_logo.png");
        texture2D = Raylib.LoadTextureFromImage(logoImage);
        Raylib.UnloadImage(logoImage);
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

        Raylib.DrawTexture(texture2D, settings.Width / 2 - texture2D.Width / 2, settings.Height / 2 - texture2D.Height / 2, Color.White);
    }

    public void Unload()
    {
        Raylib.UnloadTexture(texture2D);
    }
}