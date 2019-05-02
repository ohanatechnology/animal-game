using System;
using System.Collections.Generic;

namespace AnimalGame
{
    public struct Pair<T> : IPair<T>
    {
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public T First { get; set; }
        public T Second { get; set; }
    }
}
