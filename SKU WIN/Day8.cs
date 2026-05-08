using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SKU_WIN
{
    class Day8
    {
        class Test
        {
            //public int Power(int x)
            //{
            //    return x * x;
            //}

            //public int Multiply(int x, int y)
            //{
            //    return x * y;
            //}

            //public void Print()
            //{
            //    Console.WriteLine("Print inside message");
            //}

            //public int Sum(int min, int max)
            //{
            //    int output = 0;
            //    for(int i = min; i <= max; i++)
            //    {
            //        output += i;
            //    }
            //    return output;
            //}

            //public int Multiply(int min, int max)
            //{
            //    int output = 1;
            //    for (int i = min; i <= max; i++)
            //    {
            //        output *= i;
            //    }
            //    return output;
            //}
        }

        class MyMath
        {
            public static int Abs(int x)
            {
                if (x < 0)
                    return -x;
                else
                    return x;
            }
        }
        static void Main(string[] args)
        {
            //Test test = new Test();
            //Console.WriteLine(test.Multiply(1,10));
            Console.WriteLine(MyMath.Abs(423));
            Console.WriteLine(MyMath.Abs(-23));
        }
    }
}
