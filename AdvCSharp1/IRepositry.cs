using System;
using System.Collections.Generic;
using System.Text;

namespace AdvCSharp1
{
    #region Q6 : Write IRepository<T>. 
    internal interface IRepositry<T>
    {
        void Add(T item);
        T Get(int d);
    } 
    #endregion
}
