using System.Runtime.CompilerServices;

internal class GenericList<T>
{
   
    public string SwapValues(T value1, T value2)
    {
        T temp;
        temp = value1;
        value1 = value2;
        value2 = temp;
        return $"{value1}, {value2}";
        
    }

}
class Program
{
    public static void Main(string[] args)
    {
        GenericList<string> list = new GenericList<string>();
        Console.WriteLine( list.SwapValues("a", "b"));
        
    }
}


