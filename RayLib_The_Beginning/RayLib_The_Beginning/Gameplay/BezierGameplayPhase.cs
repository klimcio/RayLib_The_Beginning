using Raylib_cs;
using System.Numerics;

public class BezierGameplayPhase : IGamePhase
{
    private Settings settings;

    Vector2 startPoint;
    Vector2 endPoint;

    bool moveStartPoint = false;
    bool moveEndPoint = false;

    Vector2 mouse = new(0, 0);

    public BezierGameplayPhase(Settings settings)
    {
        this.settings = settings;

        startPoint = new(30, 30);
        endPoint = new((float)settings.Width - 30, (float)settings.Height - 30);
    }

    public void Draw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("MOVE START-END POINTS WITH MOUSE", 15, 20, 20, Color.Gray);

        // Draw line Cubic Bezier, in-out interpolation (easing), no control points
        Raylib.DrawLineBezier(startPoint, endPoint, 4.0f, Color.Blue);

        // Draw start-end spline circles with some details
        Raylib.DrawCircleV(startPoint, Raylib.CheckCollisionPointCircle(mouse, startPoint, 10.0f) ? 14.0f : 8.0f, moveStartPoint ? Color.Red : Color.Blue);
        Raylib.DrawCircleV(endPoint, Raylib.CheckCollisionPointCircle(mouse, endPoint, 10.0f) ? 14.0f : 8.0f, moveEndPoint ? Color.Red : Color.Blue);
    }

    public void Unload()
    {
    }

    public void Update()
    {
        mouse = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointCircle(mouse, startPoint, 10.0f) &&
            Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            moveStartPoint = true;
        }
        else if (Raylib.CheckCollisionPointCircle(mouse, endPoint, 10.0f)
            && Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            moveEndPoint = true;
        }

        if (moveStartPoint)
        {
            startPoint = mouse;
            if (Raylib.IsMouseButtonReleased(MouseButton.Left)) moveStartPoint = false;
        }

        if (moveEndPoint)
        {
            endPoint = mouse;
            if (Raylib.IsMouseButtonReleased(MouseButton.Left)) moveEndPoint = false;
        }
    }
}
