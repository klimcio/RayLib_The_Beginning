// See https://aka.ms/new-console-template for more information

using Raylib_cs;

public class GameplayPhase : IGamePhase
{
    public void Draw()
    {
        Raylib.DrawRectangle(0, 0, Program.width, Program.height, Color.Purple);
        Raylib.DrawText("GAMEPLAY SCREEN", 20, 20, 40, Color.Maroon);
        Raylib.DrawText("PRESS ENTER to JUMP to ENDING SCREEN", 290, 220, 20, Color.Maroon);
    }

    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter)) // || Raylib.IsGestureDetected(Gesture.Tap))
        {
            Program.currentScreen = GameScreen.ENDING;
        }
    }
}