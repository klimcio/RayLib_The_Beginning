﻿// See https://aka.ms/new-console-template for more information

using Raylib_cs;

public class EndingPhase : IGamePhase
{
    public void Draw()
    {
        Raylib.DrawRectangle(0, 0, Program.width, Program.height, Color.Blue);
        Raylib.DrawText("ENDING SCREEN", 20, 20, 40, Color.DarkBlue);
        Raylib.DrawText("PRESS ENTER to JUMP to TITLE SCREEN", 290, 220, 20, Color.DarkBlue);
    }

    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter)) // || Raylib.IsGestureDetected(Gesture.Tap))
        {
            Program.currentScreen = GameScreen.TITLE;
        }
    }
}