using System;
using System.IO;


namespace Generics;

public interface IPattern
{
    string Name { get; }
    int MoveCount { get; }
    void Perform();
    void Reset();
}

public interface IKiapable
{
    void PerformShout()
    {
      
    }
}



