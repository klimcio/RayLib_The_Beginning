// See https://aka.ms/new-console-template for more information

using Raylib_cs;

public class LogoPhase : IGamePhase
{
    private int frameCounter = 0;

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
        Raylib.DrawText("LOGO SCREEN " + frameCounter.ToString(), 20, 20, 40, Color.Black);
    }
}