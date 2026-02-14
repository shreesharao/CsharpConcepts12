namespace CsharpConcepts12;

public static class Topic1
{
    public static void Entry()
    {
        Console.WriteLine("Topic1: Primary Constructor");
        var topic1 = new Topic1A(1, 2, 3);
        Console.WriteLine($"topic1: {topic1}");
    }
}

public class Topic1A(int prop1, int prop2, int prop3) : Topic1B(prop3)
{
    public readonly int Prop1 = prop1;
    public int Prop2 { get; init; } = prop2;
    public override string ToString() => $"Prop1: {Prop1}, Prop2: {Prop2}, Prop3: {Prop3}";
}

public class Topic1B(int prop3)
{
    //Every other constructor for a class must call the primary constructor, 
    // directly or indirectly, through a this() constructor invocation
    //This rule ensures that primary constructor parameters are assigned everywhere in the body of the type.
    public Topic1B() : this(0)
    {

    }
    public int Prop3 { get; set; } = prop3;
}
