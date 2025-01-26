using Raylib_cs;

internal class RaylibFonts
{
    public static Font[] Fonts { get; } = new Font[11];

    public static void LoadFonts()
    {
        Fonts[0] = Raylib.LoadFont("assets/fonts/alagard.png");
        Fonts[1] = Raylib.LoadFont("assets/fonts/pixelplay.png");
        Fonts[2] = Raylib.LoadFont("assets/fonts/mecha.png");
        Fonts[3] = Raylib.LoadFont("assets/fonts/setback.png");
        Fonts[4] = Raylib.LoadFont("assets/fonts/romulus.png");
        Fonts[5] = Raylib.LoadFont("assets/fonts/pixantiqua.png");
        Fonts[6] = Raylib.LoadFont("assets/fonts/alpha_beta.png");
        Fonts[7] = Raylib.LoadFont("assets/fonts/jupiter_crash.png");
        Fonts[8] = Raylib.LoadFont("assets/fonts/custom_mecha.png");
        Fonts[9] = Raylib.LoadFont("assets/fonts/custom_alagard.png");
        Fonts[10] = Raylib.LoadFont("assets/fonts/custom_jupiter_crash.png");
    }

    public static void UnloadFonts()
    {
        foreach (var font in Fonts) { Raylib.UnloadFont(font); }
    }
}
