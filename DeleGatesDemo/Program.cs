using System;

namespace DeleGatesDemo
{
    public delegate int Opertation(int x, int y);
    class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Demo!");
            Opertation obj = new Opertation(Addition);
            Console.WriteLine("Addition is ={0}", obj(20, 30));

            MultiClassDelegate.ImplementDelegate();
        }
    }
}
