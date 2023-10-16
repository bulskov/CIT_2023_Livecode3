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
        var courses = Data.GetCourses();

        var pq = persons
            .Where(x => x.Age < 25)
            .Select(x => new { x.Name, x.Age })
            .ToArray();

        


        var jq = persons.Join(
            courses,
            p => p.CourseId,
            c => c.Id,
            (p, c) => new { p, c });

        var num = Data.GetRandomNumbers(10);


        //var p = persons.FirstOrDefault(x => x.Age == 21);

        //Console.WriteLine(p);

        //foreach (var x in jq.Select(x => new { PersonName = x.p.Name, CourseName = x.c.Name }))
        //{
        //    Console.WriteLine(x);
        //}

        //var gq = persons.GroupBy(
        //    p => p.Age);

        //foreach(var element in gq)
        //{
        //    Console.WriteLine(element.Key);

        //    foreach(var e in element)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}



    }
}

