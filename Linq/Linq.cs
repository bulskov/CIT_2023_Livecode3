namespace Linq;

static class MyExt
{
    public static IEnumerable<T> MyWhere<T>
        (this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(var element in collection)
        {
            if(predicate(element))
            {
                yield return element;  
            }
        }
    }

    public static IEnumerable<S> MySelect<T, S>
       (this IEnumerable<T> collection, Func<T, S> fn)
    {
        foreach (var element in collection)
        {
            yield return fn(element);
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] number = { 1, 2, 3, 4, 5 };

        var q = number.Where(x => x >= 4);

        var persons = Data.GetPersonData();

        var pq = persons
            .MyWhere(x => x.Age < 25)
            .MySelect(x => new { x.Name, x.Age });

        var num = Data.GetRandomNumbers(10);

        foreach (var x in pq)
        {
            Console.WriteLine(x);
        }

    }
}

