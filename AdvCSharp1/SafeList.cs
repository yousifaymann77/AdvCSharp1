using System;
using System.Collections.Generic;
using System.Text;

namespace AdvCSharp1
{
    #region Q14: Write a SafeList<T> that returns default when the index is invalid
    internal class SafeList<T>
    {
        private List<T> items = new List<T>();

        public T GetItem(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                return default;
            }
            return items[index];
        }
    } 
    #endregion
}
