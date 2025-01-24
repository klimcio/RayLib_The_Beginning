using Raylib_cs;

public class FontTitlePhase : IGamePhase
{
    private Settings settings;

    public FontTitlePhase(Settings settings)
    {
        this.settings = settings;
    }

    public void Draw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("free fonts included with raylib", 250, 20, 20, Color.DarkGray);
        Raylib.DrawLine(220, 50, 590, 50, Color.DarkGray);

        var exampleMessages = ExampleMessage.Messages;

        for (int i = 0; i < exampleMessages.Count; i++)
        {
            var message = exampleMessages[i];
            var font = RaylibFonts.Fonts[i];

            Raylib.DrawTextEx(
                font, 
                message.Text,
                message.Position,
                font.BaseSize * 2.0f,
                (float)message.Spacing, 
                message.Color);
        }
    }

    public void Unload()
    {
    }

    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            Program.currentScreen = GameScreen.GAMEPLAY;
        }
    }
}
