namespace AdvCSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            // It is a class that can work with different data Types
            // code reusability , Better performance , Type safety 
            #endregion

            #region Q3 : What are multiple type parameters?
            // Means that a class can have more than one type parameter
            #endregion

            #region Q4 : What is a generic method?
            // a method that has its own type params and can work with different data types
            #endregion

            int a = 44;
            int b = 5;
            swap(ref a,ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            #region Q6: What is a generic interface?
            // Interface that can work with different Types
            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            // it means that the T type must be a value type

            //Container<int> conint = new Container<int>(); // valid
            //Container<string> constr = new Container<string>(); // invalid

            #endregion

            #region Q8: What is the 'class' constraint? Write an example.
            // means that the T type must be a refrence type

            //Container<int> conint = new Container<int>(); // invalid
            //Container<string> constr = new Container<string>(); // valid
            #endregion


            #region Q9: What is the 'new()' constraint? Write an example.
            // means that the T type must have a parameterless ctor
            //Container<Box> box1 = new Container<Box>(); // valid
            #endregion


            #region Q10:  What is the interface constraint? Write an example.
            // means that T type must must implement a specific interface
            //Container<Box> box2 = new Container<Box>(); // invalid because it is does not implement the interface
            #endregion


            #region Q11: What is the base class constraint? Write an example
            // means that T or its derived types must inherit from base class
            //PersonContainer<Employee> emp = new PersonContainer<Employee>();
            #endregion


            #region Q12: How do you apply multiple constraints? Write an example.
            // by adding multiple constraints in the generic declaration 
            // PersonContainer<Employee> emp2 = new PersonContainer<Employee>(); // it inherits from base class but does not have prameterless ctor
            #endregion


            #region Q13: What does the 'default' keyword do in generics?
            // It returns the default value of a type
            #endregion


            #region Q15: What is covariance? Explain the 'out' keyword.
            // means that te generic type is used as output or producer and the out keyword used to enable covariance
            #endregion


            #region Q16: What is contravariance? Explain the 'in' keyword.
            // means that the generic type is used as input or consumer and the in keyword used to enable contravariance
            #endregion


            #region Q17: What is the difference between covariance and contravariance?
            //Covariance allows a generic type to use a derived type where a base type is expected mainly for output
            //Contravariance allows a generic type to use a base type where a derived type is expected mainly for input
            #endregion


            #region Q18: How do static members work in generic types?
            // each closed generic type has its own shared static member
            #endregion


            #region Q19: How can you inherit from a generic class?
            // By specifying the type argument 
            #endregion

        }




        #region Q4 : Write Swap<T> method.
        public static void swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Q5 : Write a generic method FindMax<T> that finds maximum value
        public static T FindMax<T>(T[] values) where T : IComparable<T>
        {
            T max = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;
        } 
        #endregion
    }
}
