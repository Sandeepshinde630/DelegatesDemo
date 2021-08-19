using System;
using System.Collections.Generic;
using System.Text;

namespace DeleGatesDemo
{
    public class MultiClassDelegate
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            DelOp obj = Operation.Add;
            obj += Operation.Square;

            obj(5, 3);
            obj(5, 6);
            Console.ReadLine();
        }
        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Add={0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple={0}", a * b);
            }
        }
    }
}
