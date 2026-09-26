using System;
using System.Collections.Generic;
using System.Text;

namespace AdvCSharp1
{
    internal class PersonContainer<T> where T : Person , new()
    {
        public void MakeWalk(T Person)
        {
            Person.Walk();
        }
    }
}
