using Raylib_cs;
using System.Numerics;

namespace RayLib_The_Beginning;

internal static class DrawingExtensions
{
    public static void DrawCircle(this Vector2 position, int radius, Color color)
        => Raylib.DrawCircleV(position, radius, color);
}
