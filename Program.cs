namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Chonji cTul = new();
        // cTul.Perform();
        // cTul.Reset();
        cTul.Moves();

        // WonHyo wTul = new();
        // wTul.PerformShout();
        // foreach (Chon e in Enum.GetValues(typeof(Chon)))
        // {
        //     Console.WriteLine(e);
        // }

        // var chonValues = Enum.GetValues(typeof(Chon));
        // Console.WriteLine(chonValues.GetValue(5));
        // cTul.FirstQuadrant();

        if (Chon.LeftHandedLowBlock  is Chon c) { Console.WriteLine($"Turn and step out to the left and perform a low left handed low block before stepping forward with your right leg to perform a right handed punch"); }
        if (Chon.RightHandedLowBlock is Chon d) { Console.WriteLine($"Turn back and step out to the right and perform a low right handed low block before stepping forward with your left leg to perform a left handed punch"); }
        
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
