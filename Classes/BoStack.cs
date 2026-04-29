using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Generics;

class BoStack<T>(int boSize)
{
    private int _boPosition;
    private readonly T[] _boStack = new T[boSize];
    public void Push(T boBject)
    {
        if(_boPosition < boSize) _boStack[_boPosition++] = boBject;
    }
    
    public T Pop()
    {
        return _boPosition > 0 ? _boStack[--_boPosition] : default!;
    }



} 

//Usage: If you create var myArr = new BoArray<string>(5);,
// you can write myArr[0] = "Hello";
// instead of calling a method like myArr.SetValue(0, "Hello");.
class BoArray<T>(int aSize)
{
    private readonly T[] _boBarray = new T[aSize];
    public T this[int index]
    {
        get => _boBarray[index];  
        set => _boBarray[index] = value;
    }
  
}



    // class BoArray<T>(int aSize)
    // {
        
    // }
    // private T[] _boStack = new T[boSize];
    // public void Push(T boBject) => _boStack[_boPosition++] = boBject;
    // public T Pop()              => _boStack[--_boPosition];