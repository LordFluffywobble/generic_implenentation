
namespace Generics;

enum Chon
{
    ReadyPos,
    LeftHandedLowBlock,
    RightHandedPunch,
    RightHandedLowBlock,
    LeftHandedPunch,
    LeftHandedHighBlock,
    RightHandedHighBlock,
    LeftBackFoot,
    RightBackFoot
}
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

    public void FirstQuadrant()
    {
        Console.WriteLine($"Step to the left and perform a {Chon.LeftHandedLowBlock} followed by a right step forward and a {Chon.RightHandedPunch}");
    }

    public void Moves()
    {
        Console.WriteLine($"{Name} has {MoveCount} moves\n");
    }
}

//All turns are from a full circles's perspective

//Ready Position

//Step 1 and 2
//Turn a quarter left, step with yout left foot forward to a low left block
//Step forward with right foot and punch with the right hand

//Step back and turn halfway back before stepping out with your right leg into a low right handed block
//Step forward with your left leg and punch with your left hand
//Repeat step 1 and 2

//Now repeat using a backfoot stance for the blocks and innherhand, high blocks instead of low blocks

//Continue with a step forward and a punch with the right hand
//Then a step backwards and a left handed punch and repeat with the right hand and leg
//Finish with a delightful exclamation of "Chon-Ji"


//Need a way to tell us that we're turning or maybe a turning one that takes a few arguments about techniques