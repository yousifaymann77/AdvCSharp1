using System;
using System.Collections.Generic;
using System.Text;

namespace AdvCSharp1
{
    internal class Employee : Person 
    {
        public Employee(int myProperty)
        {
            MyProperty = myProperty;
        }

        public int MyProperty { get; set; }


    }
}
