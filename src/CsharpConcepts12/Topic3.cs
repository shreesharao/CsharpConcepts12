namespace CsharpConcepts12;

public static class Topic3
{
 public static void Entry()
    {
        Console.WriteLine("Topic3: Inline Array");
        var buffer = new Buffer();
        for (int i = 0; i < 10; i++)
        {
            buffer[i] = i;
        }
        foreach (var element in buffer)
        {
            Console.WriteLine(element);
        }
    }
}

[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private int element;
}
