
public class Program
{

    static IEnumerable<string> Foo()
    {
        yield return "One";
        yield return "Two";
        yield return "Three";

    }

    static IEnumerable<int> Numbers()
    {
        var count = 1;
        while (true)
        {
            if (count % 2 != 0)
                yield return count;
            count++;
        }
    }
    public static void Main()
    {
        foreach(var x in Numbers().Take(10))
        {
            Console.WriteLine(x);
        }

    }
}