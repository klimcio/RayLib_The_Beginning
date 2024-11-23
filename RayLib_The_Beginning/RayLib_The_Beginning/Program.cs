// See https://aka.ms/new-console-template for more information
using Raylib_cs;

const int width = 800;
const int height = 480;
const string title = "Hello World";

Raylib.InitWindow(width, height, title);

Raylib.SetTargetFPS(60);

// Main game loop
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);

    Raylib.DrawText("Congrats! You have created your first window!", 190, 200, 20, Color.LightGray);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
