using System;

namespace Abstract
{
    namespace A
    {
        abstract class Parent
        {
            public void Test()
            {
                Console.WriteLine("Parent Test");
            }
        }

        class Child : Parent
        {
            public new void Test()
            {
                Console.WriteLine("Child Test");
            }
        }
    }

    namespace B
    {
        abstract class Parent
        {
            public abstract void Test();
        }

        class Child : Parent
        {
            public override void Test()
            {
                Console.WriteLine("Override Test");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A.Child childA = new A.Child();
            childA.Test();

            B.Child childB = new B.Child();
            childB.Test();
        }
    }
}