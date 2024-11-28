using Raylib_cs;

enum GameScreen { LOGO = 0, TITLE, GAMEPLAY, ENDING };

internal class Program
{
    private static bool currentScreenChanged = true;
    
    private static GameScreen _currentScreen = GameScreen.LOGO;
    public static GameScreen currentScreen 
    { 
        get => _currentScreen;
        set
        {
            if (value == _currentScreen)
                currentScreenChanged = false;
            else
            {
                currentScreenChanged = true;
                _currentScreen = value;
            }
        }
    }

    public const int width = 800;
    public const int height = 450;

    private static void Main(string[] args)
    {
        const string title = "Hello World";

        Raylib.InitWindow(width, height, title);
        Raylib.SetTargetFPS(60);

        IGamePhase currentGamePhase = GetGamePhase(currentScreen);

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            if (currentScreenChanged)
                currentGamePhase = GetGamePhase(currentScreen);

            currentGamePhase.Update();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RayWhite);

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
