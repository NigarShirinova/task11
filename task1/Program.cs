using task1;

class Program
{
   public static void Main(string[] args)
    {
        CustomList<int> list = new CustomList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        Console.WriteLine(list.LastOrDefault());
        Console.WriteLine( list.FirstOrNull());
        list.GetAll();
        list.Remove(1);
        list.GetAll();
        Console.WriteLine( list.Contains(2));
        Console.WriteLine( list.Contains(20));
        Console.WriteLine( list.Any());
        list.Clear();
        Console.WriteLine( list.Any());
        Console.WriteLine(list.FirstOrNull());
        Console.WriteLine(list.LastOrDefault());
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.GetAll();
        Console.WriteLine(list.ElementAtOrDefault(2));
        Console.WriteLine(list.ElementAtOrDefault(30));


    }
}
