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

            Container<int> conint = new Container<int>(); // valid
           //Container<string> constr = new Container<string>(); // invalid

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
