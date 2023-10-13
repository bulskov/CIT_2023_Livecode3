namespace Linq;

public class Program
{
    public static void Main()
    {
        int[] number = { 1, 2, 3, 4, 5 };

        var q = number.Where(x => x >= 4);

        var persons = Data.GetPersonData();

        var pq = persons
            .Where(x => x.Age < 25)
            .Select(x => new { x.Name, x.Age });

        var num = Data.GetRandomNumbers(10);

        foreach (var x in num.OrderByDescending(x => x))
        {
            Console.WriteLine(x);
        }

    }
}

