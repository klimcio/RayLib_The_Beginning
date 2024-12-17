﻿// See https://aka.ms/new-console-template for more information

using Raylib_cs;

public class TitlePhase : IGamePhase
{
    private Settings settings;

    public TitlePhase(Settings settings)
    {
        this.settings = settings;
    }

    public void Draw()
    {
        Raylib.DrawRectangle(0, 0, settings.Width, settings.Height, Color.Green);
        Raylib.DrawText("TITLE SCREEN", 20, 20, 40, Color.DarkGreen);
        Raylib.DrawText("PRESS ENTER to JUMP to GAMEPLAY SCREEN", 290, 220, 20, Color.DarkGreen);
    }

    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter)) // || Raylib.IsGestureDetected(Gesture.Tap))
        {
            Program.currentScreen = GameScreen.GAMEPLAY;
        }
    }
}