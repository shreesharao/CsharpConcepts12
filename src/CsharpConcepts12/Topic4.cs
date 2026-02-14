namespace CsharpConcepts12;

public static class Topic4
{
    public static void Entry()
    {
        Console.WriteLine("Topic4: Default lambda parameters");

        //Lambda expressions with default parameters or params collections as parameters 
        // don't have natural types that correspond to Func<> or Action<> types.
        var print = (string input, bool toUpper = false) => Console.WriteLine(toUpper ? input.ToUpper() : input.ToLower());
        var printParams = (params int[] values) => Console.WriteLine(string.Join(", ", values));

        print("Hello", true);
        print("Hello");
        printParams(1, 2, 3);
    }
}
