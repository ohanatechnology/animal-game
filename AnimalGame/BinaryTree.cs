using System;
using System.Collections.Generic;

namespace AnimalGame
{
    public class BinaryTree<T>
    {
        public BinaryTree( T item )
        {
            Item = item;
        }

        public T Item { get; set; }
        public Pair<BinaryTree<T>> SubItems { get; set; }
    }
}
