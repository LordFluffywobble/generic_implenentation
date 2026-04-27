using System;
using System.ComponentModel;

namespace Generics;

class BoStack<T>(int boSize)
{
    private int _boPosition;
    private T[] _boboStack = new T[boSize];
    public void Push(T boBject) => _boboStack[_boPosition++] = boBject;
    public T Pop()              => _boboStack[--_boPosition];
} 