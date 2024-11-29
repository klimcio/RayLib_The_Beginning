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
        Raylib.SetTargetFPS(60);

        IGamePhase currentGamePhase = GetGamePhase(currentScreen);

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            currentGamePhase = GetGamePhase(currentScreen);

            currentGamePhase.Update();

            Raylib.BeginDrawing();

            currentGamePhase.Draw();

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
