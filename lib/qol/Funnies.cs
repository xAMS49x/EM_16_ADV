using Libraries;

namespace Libraries;

public class Funnies
{
    public static string[] Phrases =
    {
        "DIE INSIDE THE FLAMES OF YOUR FRIGHT!",
        "Pitiful humanity fell into the abyss.\nGame set, before you ever try to fight.",
        "The slaughter's on,\nI'd love to see you come undone!",
        "Did you know you can make you computer run faster?\n It's simple! You just press Alt+F4",
        "Heavy hearts won't grieve\nThat soon I`ll be that body in the bag...",
        "Still, morning comes and you can't outrun\nThe warm glow of the sun...",
        "Don't get me wrong, I'd love to change my paradigm\nBut when life gives lemons hand over fist\nThere's only so much you can fix.",
        "I hold no gods, I make no prayer.\nMy mind is still, my heart is bare.",
        "HAIL THINE DIVINE LORD JILL! KILL THE HERETICS! JUDGEMENT FOR UNBELIEVERS!",
        "Oh blood and viscera divine...",
        "Can you feel it? Void stares back.",
        "Rev the engine, make your fate!",
        "Love? That's useless.\nPity? It's a deceitful thing.",
        "Water rises and creates a vibrance\nTo bring me home far away from violence!",
        "Power awaits those, who take command!",
        "\"Microsoft isn't evil, they just make really crappy operating systems.\" - Linus Torvalds",
        "As the hours pass\nI will let you know\nThat I need to ask\nBefore I'm alone...",
        "And now I'm here, remembering\nStuck behind a screen that never dares break in two.",
        "Thanks for checking in, I'm not doing well.",
        "I'm watching when you are cruel, create invisible rules\nBecome a twisted reflection of you."

    };
    
    public static void PhraseMsg(string msg, ConsoleColor color = ConsoleColor.DarkRed)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(msg);
        Console.WriteLine();
        Console.ResetColor();
    }
    
    public static void GetFunnyPhrase()
    {
        PhraseMsg(Phrases[Get.GetRandom(0, Phrases.Length)]);
    }
    
}