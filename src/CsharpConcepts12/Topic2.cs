using System.Diagnostics.Contracts;

namespace CsharpConcepts12;

public static class Topic2
{
    public static void Entry()
    {
        Console.WriteLine("Topic2: Collection Expressions");
        int[] arr = [1, 2, 3];
        int[] arr2 = [.. arr, 4, 5];

        Console.WriteLine($"arr: {string.Join(", ", arr)}");
        Console.WriteLine($"arr2: {string.Join(", ", arr2)}");

        Print(["Hello,", "How", "Are", "You", "?"]);
    }

    public static void Print(List<string> list)
    {
        Console.WriteLine(string.Join(" ", list));
    }
}
