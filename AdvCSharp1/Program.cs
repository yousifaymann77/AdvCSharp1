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
    }
}
