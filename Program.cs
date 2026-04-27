namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        var intStack = new Stack<int>(10);  
        intStack.Push(10); 
        intStack.Push(23);

        var number = intStack.Pop();
        Console.WriteLine(number); 
    }
}
