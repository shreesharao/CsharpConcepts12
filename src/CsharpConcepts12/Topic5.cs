namespace CsharpConcepts12;

public static class Topic5
{
    public static void Entry()
    {
        Console.WriteLine("Topic5: Ref Readonly");
        var point = new Point();
        TryAssign(ref point);
        
        //Warning: Argument 1 should be a variable because it is passed to a 'ref readonly' parameter
        TryAssign(new Point());
        Console.WriteLine(point);
    }
    public static void TryAssign(ref readonly Point point)
    {
        //Error: Cannot assign to variable 'point' or 
        // use it as the right hand side of a ref assignment because it is a readonly variable
        //point = new Point();
        Console.WriteLine($"Value inside {nameof(TryAssign)}: {point}");
    }
}

public record struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
