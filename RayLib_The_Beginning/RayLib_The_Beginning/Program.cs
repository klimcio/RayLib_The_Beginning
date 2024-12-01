using Raylib_cs;

enum GameScreen { LOGO = 0, TITLE, GAMEPLAY, ENDING };

internal class Program
{
    public static GameScreen currentScreen { get; set; } = GameScreen.LOGO;

    public const int width = 800;
    public const int height = 450;

    private static void Main(string[] args)
    {
        Raylib.InitWindow(width, height, "Hello World");
        Raylib.SetExitKey(KeyboardKey.Null);
        Raylib.SetTargetFPS(60);

        bool exitWindowRequested = false;
        bool exitWindow = false;

        IGamePhase currentGamePhase = GetGamePhase(currentScreen);

        // Main game loop
        while (!exitWindow)
        {
            if (Raylib.WindowShouldClose() || Raylib.IsKeyPressed(KeyboardKey.Escape))
                exitWindowRequested = true;

            if (exitWindowRequested)
            {
                if (Raylib.IsKeyPressed(KeyboardKey.Y)) exitWindow = true;
                else if (Raylib.IsKeyPressed(KeyboardKey.N)) exitWindowRequested = false;
            }

            currentGamePhase = GetGamePhase(currentScreen);

            currentGamePhase.Update();

            Raylib.BeginDrawing();

            if (exitWindowRequested)
            {
                Raylib.DrawRectangle(0, 100, width, 200, Color.Black);
                Raylib.DrawText("Do you really want to exit?", 40, 180, 30, Color.White);
                Raylib.DrawText("Press Y to confirm or N to cancel", 120, 200, 20, Color.LightGray);
            }
            else
            {
                currentGamePhase.Draw();
            }


            Raylib.EndDrawing();
        }

        // TODO: Unload all loaded data (textures, fonts, audio) here!

        Raylib.CloseWindow();
    }

    private static IGamePhase? logoPhase;
    private static IGamePhase? gameplayPhase;
    private static IGamePhase? titlePhase;
    private static IGamePhase? endingPhase;

    private static IGamePhase GetGamePhase(GameScreen currentScreen)
    {
        return currentScreen switch
        {
            GameScreen.TITLE => titlePhase == null ? titlePhase = new TitlePhase() : titlePhase,
            GameScreen.GAMEPLAY => gameplayPhase == null ? gameplayPhase = new GameplayPhase() : gameplayPhase,
            GameScreen.ENDING => endingPhase == null ? endingPhase = new EndingPhase() : endingPhase,
            _ => logoPhase == null ? logoPhase = new LogoPhase() : logoPhase,
        };
    }
}
