namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Chonji cTul = new();
        cTul.Perform();
        cTul.Reset();
        Console.WriteLine($"The pattern {cTul.Name} has {cTul.MoveCount} moves");

        WonHyo wTul = new();
        wTul.PerformShout();

        // var intStack = new Stack<int>(10);  
        // intStack.Push(10); 
        // intStack.Push(56);

        // var number = intStack.Pop();
        // // var numbers = intStack.Pop();
        // Console.WriteLine(number); 
        // // Console.WriteLine(numbers); 

        // var MyArray = new BoArray<string>(5);
        // MyArray[0] = "Hello Bo";
        // Console.WriteLine(MyArray[0]); 
    }
}
