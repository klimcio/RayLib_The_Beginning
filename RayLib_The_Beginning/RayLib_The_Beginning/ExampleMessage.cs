using Raylib_cs;
using System.Numerics;

internal record ExampleMessage(string Text, int Spacing, Color Color, Vector2 Position)
{
    public static List<ExampleMessage> Messages => new()
    {
        new ExampleMessage("ALAGARD FONT designed by Hewett Tsoi", 2, Color.Maroon, new Vector2(20, 70)),
        new ExampleMessage("PIXELPLAY FONT designed by Aleksander Shevchuk", 4, Color.Orange, new Vector2(20, 100)),
        new ExampleMessage("MECHA FONT designed by Captain Falcon", 8, Color.DarkGreen, new Vector2(20, 130)),
        new ExampleMessage("SETBACK FONT designed by Brian Kent (AEnigma)", 4, Color.DarkBlue, new Vector2(20, 160)),
        new ExampleMessage("ROMULUS FONT designed by Hewett Tsoi", 3, Color.DarkPurple, new Vector2(20, 190)),
        new ExampleMessage("PIXANTIQUA FONT designed by Gerhard Grossmann", 4, Color.Lime, new Vector2(20, 220)),
        new ExampleMessage("ALPHA_BETA FONT designed by Brian Kent (AEnigma)", 4, Color.Gold, new Vector2(20, 250)),
        new ExampleMessage("JUPITER_CRASH FONT designed by Brian Kent (AEnigma)", 1, Color.Red, new Vector2(20, 280))
    };
}
