using System;
using System.Collections.Generic;
using System.Text;

namespace AdvCSharp1
{
    #region  Q2 : Write a generic class Container<T> with Add and Get methods.
    internal class Container<T> where T : class
    {
        public T Item { get; set; }

        public void Add(T value)
        {
            Item = value;
            Console.WriteLine($"Item {value} is Added successfully");
        }

        public T Get()
        {
            return Item;
        }
    } 
    #endregion
}
