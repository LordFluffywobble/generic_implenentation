namespace Generics;


public class WonHyo : IPattern, IKiapable
{
    public string Name => "Won-Hyo";
    public int MoveCount => 28;
    public void Perform()   { Console.WriteLine($"Performing {MoveCount} moves, starting with a low block."); }
    public void Reset()     { Console.WriteLine($"Returning to {Name}'s Chon-bi (Ready Stance)."); }
    public void PerformShout()
    {
        Console.WriteLine("KIAP!");
    }

}