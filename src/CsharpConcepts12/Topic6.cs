using ListAlias = System.Collections.Generic.List<string>;
namespace CsharpConcepts12;

public static class Topic6
{
    public static void Entry()
    {
        ListAlias lst = ["Hello", "How", "Are", "You"];
        Console.WriteLine(string.Join(" ", lst));
    }
}
