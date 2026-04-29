
namespace Generics;


public class Chonji : IPattern
{
    public string Name => "Chon-Ji";
    public int MoveCount => 19;
    public void Perform()
    {
        Console.WriteLine($"Performing {MoveCount} moves, starting with a low block.");
    }

    public void Reset()
    {
        Console.WriteLine($"Returning to {Name}'s Chon-bi (Ready Stance).");
    }
}