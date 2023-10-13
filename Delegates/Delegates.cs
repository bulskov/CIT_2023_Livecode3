

public class Program
{
    delegate int Transformer(int x);
    public static void Main()
    {
        Transformer fn = Square;

        //Console.WriteLine(fn(5));

        int[] numbers = { 1, 2, 3, };

        Print(x => x + 10, numbers);
    }


    static void Print(Func<int, int> fn, int[] values)
    {
        foreach(var n in values)
        {
            Console.WriteLine(fn(n));
        }
    }


    static int Square(int x)
    {
        return x * x;
    }

    static int Cube(int x)
    {
        return x * x * x;
    }


}