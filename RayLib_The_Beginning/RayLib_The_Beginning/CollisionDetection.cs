﻿using Raylib_cs;

public static class CollisionDetection
{
    public static bool IsCollidingWithScreenBorderX(this IAmA2dBeing being)
        => (being.position.X >= (Raylib.GetScreenWidth() - being.radius)) || (being.position.X <= being.radius);

    public static bool IsCollidingWithScreenBorderY(this IAmA2dBeing being)
        => (being.position.Y >= (Raylib.GetScreenHeight() - being.radius)) || (being.position.Y <= being.radius);
}