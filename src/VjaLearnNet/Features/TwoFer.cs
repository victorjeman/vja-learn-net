namespace VjaLearnNet.Features;

// First "feature", ported from the Exercism two-fer exercise.
// Treat each exercise like this: a small capability the app gains, with tests.
public static class TwoFer
{
    public static string Name(string name = "you")
    {
        return $"One for {name}, one for me.";
    }
}
