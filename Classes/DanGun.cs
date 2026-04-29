
namespace Generics;

public class DanGun : IPattern
{
    public string Name => "Dan-Gun";
    public int MoveCount => 21;
    public void Perform()
    {
        Console.WriteLine($"Performing {MoveCount} moves, starting with a High Block");
    }

    public void Reset() => Console.WriteLine($"Returning to {Name}'s Chon-bi (Ready Stance)");
}
