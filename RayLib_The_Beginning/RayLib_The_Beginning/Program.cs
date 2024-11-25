// See https://aka.ms/new-console-template for more information
using Raylib_cs;

enum GameScreen { LOGO = 0, TITLE, GAMEPLAY, ENDING };

internal class Program
{
    private static void Main(string[] args)
    {
        const int width = 800;
        const int height = 450;
        const string title = "Hello World";

        Raylib.InitWindow(width, height, title);

        GameScreen currentScreen = GameScreen.LOGO;

        int frameCounter = 0;
        Raylib.SetTargetFPS(60);

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            switch (currentScreen)
            {
                case GameScreen.LOGO:
                    frameCounter++;
                    if (frameCounter > 120)
                    {
                        currentScreen = GameScreen.TITLE;
                    }
                    break;
                case GameScreen.TITLE:
                    // TODO: Update TITLE screen variables here!

                    if (Raylib.IsKeyPressed(KeyboardKey.Enter)) // || Raylib.IsGestureDetected(Gesture.Tap))
                    {
                        currentScreen = GameScreen.GAMEPLAY;
                    }
                    break;
                case GameScreen.GAMEPLAY:
                    // TODO: Update GAMEPLAY screen variables here!

                    if (Raylib.IsKeyPressed(KeyboardKey.Enter)) // || Raylib.IsGestureDetected(Gesture.Tap))
                    {
                        currentScreen = GameScreen.ENDING;
                    }
                    break;
                case GameScreen.ENDING:
                    // TODO: Update ENDING screen variables here!

                    if (Raylib.IsKeyPressed(KeyboardKey.Enter)) // || Raylib.IsGestureDetected(Gesture.Tap))
                    {
                        currentScreen = GameScreen.TITLE;
                    }
                    break;
                default:
                    break;
            }

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RayWhite);

            switch (currentScreen)
            {
                case GameScreen.LOGO:
                    Raylib.DrawText("LOGO SCREEN", 20, 20, 40, Color.LightGray);
                    Raylib.DrawText("WAIT for 2 SECONDS", 290, 220, 20, Color.Gray);
                    break;
                case GameScreen.TITLE:
                    // TODO: Draw TITLE screen here!
                    Raylib.DrawRectangle(0, 0, width, height, Color.Green);
                    Raylib.DrawText("TITLE SCREEN", 20, 20, 40, Color.DarkGreen);
                    Raylib.DrawText("PRESS ENTER to JUMP to GAMEPLAY SCREEN", 290, 220, 20, Color.DarkGreen);
                    break;
                case GameScreen.GAMEPLAY:
                    // TODO: Draw GAMEPLAY screen here!
                    Raylib.DrawRectangle(0, 0, width, height, Color.Purple);
                    Raylib.DrawText("GAMEPLAY SCREEN", 20, 20, 40, Color.Maroon);
                    Raylib.DrawText("PRESS ENTER to JUMP to ENDING SCREEN", 290, 220, 20, Color.Maroon);
                    break;
                case GameScreen.ENDING:
                    // TODO: Draw ENDING screen here!
                    Raylib.DrawRectangle(0, 0, width, height, Color.Blue);
                    Raylib.DrawText("ENDING SCREEN", 20, 20, 40, Color.DarkBlue);
                    Raylib.DrawText("PRESS ENTER to JUMP to TITLE SCREEN", 290, 220, 20, Color.DarkBlue);
                    break;
                default:
                    break;
            }

            Raylib.EndDrawing();
        }

        // TODO: Unload all loaded data (textures, fonts, audio) here!

        Raylib.CloseWindow();
    }
}
