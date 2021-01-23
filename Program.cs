using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();

            fourOperations.Add(2, 9);
            fourOperations.Add(6, 9);
            fourOperations.Multiplication(9, 6);
        }
    }
}
