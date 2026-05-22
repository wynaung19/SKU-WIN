//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;

//namespace SKU_WIN
//{
//    class Day8
//    {
//        //class Test
//        //{
//        //    //public int Power(int x)
//        //    //{
//        //    //    return x * x;
//        //    //}

//        //    //public int Multiply(int x, int y)
//        //    //{
//        //    //    return x * y;
//        //    //}

//        //    //public void Print()
//        //    //{
//        //    //    Console.WriteLine("Print inside message");
//        //    //}

//        //    //public int Sum(int min, int max)
//        //    //{
//        //    //    int output = 0;
//        //    //    for(int i = min; i <= max; i++)
//        //    //    {
//        //    //        output += i;
//        //    //    }
//        //    //    return output;
//        //    //}

//        //    //public int Multiply(int min, int max)
//        //    //{
//        //    //    int output = 1;
//        //    //    for (int i = min; i <= max; i++)
//        //    //    {
//        //    //        output *= i;
//        //    //    }
//        //    //    return output;
//        //    //}
//        //}

//        class MyMath
//        {
//            public static int Abs(int x)
//            {
//                if (x < 0)
//                    return -x;
//                else
//                    return x;
//            }

//            public static double Abs(double x)
//            {
//                if (x < 0)
//                    return -x;
//                else
//                    return x;
//            }

//            public static long Abs(long x)
//            {
//                if (x < 0)
//                    return -x;
//                else
//                    return x;
//            }
//        }

//        class Fibonacci
//        {
//            public static int Get(int n)
//            {
//                if (n == 0)
//                    return 0;
//                else if (n == 1)
//                    return 1;
//                else
//                    return Get(n - 1) + Get(n - 2);
//            }
//        }

//        static int Test(int x)
//        {
//            return 10;
//        }
//        static int Test(long x)
//        {
//            return 20;
//        }
//        static int Test(float x)
//        {
//            return 30;
//        }
//        static int Test(double x) {
//            return 40;
//        }
//        static void Main(string[] args)
//        {
//            //Fibonacci fibo = new Fibonacci();
//            //Console.WriteLine(Fibonacci.Get(1));
//            //Console.WriteLine(Fibonacci.Get(2));
//            //Console.WriteLine(Fibonacci.Get(3));
//            //Console.WriteLine(Fibonacci.Get(4));
//            //Console.WriteLine(Fibonacci.Get(5));

//            Console.WriteLine(Test(56363));
//            Console.WriteLine(Test(34.345));
//            Console.WriteLine(Test(563634623452345));
//        }
//    }
//}
