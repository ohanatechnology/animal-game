using System;

namespace AnimalGame
{
    interface IPair<T>
    {
        T First { get; set; }
        T Second { get; set; }
    }
}
