using Raylib_cs;
using System.Numerics;

public class ParallaxBackground
{
    private const float Scale = 2.0f;
    private const float Rotation = 0.0f;
    private float scrolling = 0.0f;
    private Texture2D Texture;
    private float ScrollingSpeed;

    private ParallaxBackground(Texture2D texture, float scrollingSpeed)
    {
        Texture = texture;
        ScrollingSpeed = scrollingSpeed;
    }

    public static ParallaxBackground Create(string texturePath, float scrollingSpeed)
    {
        var texture = Raylib.LoadTexture(texturePath);
        return new ParallaxBackground(texture, scrollingSpeed);
    }

    public void Draw()
    {
        Raylib.DrawTextureEx(Texture, new Vector2(scrolling, 20), Rotation, Scale, Color.White);
        Raylib.DrawTextureEx(Texture, new Vector2(Texture.Width * 2 + scrolling, 20), Rotation, Scale, Color.White);
    }

    public void Update()
    {
        scrolling -= ScrollingSpeed;

        // NOTE: Texture is scaled twice its size, so it sould be considered on scrolling
        if (scrolling <= -Texture.Width * 2) scrolling = 0;
    }

    public void Unload()
    {
        Raylib.UnloadTexture(Texture);
    }
}