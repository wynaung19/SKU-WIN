using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKU_WIN
{
    internal class Day6
    {
        static void Main(string[] args)
        {
            //int[] intArr = { 1, 2, 3, 4, 5 };
            //intArr[0] = 10;
            //Console.WriteLine(intArr[0]);
            //Console.WriteLine(intArr[1]);
            //Console.WriteLine(intArr[2]);
            //Console.WriteLine(intArr[3]);
            //Console.WriteLine(intArr[4]);

            //int[] intArr = new int[100];
            //Console.WriteLine(intArr[0]);
            //Console.WriteLine(intArr[1]);

            //int i = 0;
            //int[] intArr = { 23, 52, 273, 103, 34 };

            //while (i < intArr.Length)
            //{
            //    Console.WriteLine(i + " > " + intArr[i]);
            //    i++;
            //}

            //string input;
            //do
            //{
            //    Console.WriteLine("Enter exit to exit.");
            //    input = Console.ReadLine();
            //}
            //while (input != "exit");

            //int output = 0;
            //for(int i =0;i<=100;i++)
            //{
            //    output += i;
            //}
            //Console.WriteLine(output);

            //int output = 1;
            // for (int i = 1; i <= 20; i++)
            // {
            //     output *= i;
            // }
            // Console.WriteLine(output);

            //for (int i = 'A'; i <= 'Z'; i++)
            //{
            //    Console.WriteLine((char)i);
            //}

            //int[] intArr = { 1, 2, 3, 4, 5 };
            //for (int i = intArr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(intArr[i]);
            //}

            //string[] arr = { "A", "B", "C", "D", "E" };
            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] arr = { "A", "B", "C", "D", "E" };
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < i+1; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10 - i; j++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            //while (true)
            //{
            //    Console.WriteLine("Enter Number (Even to exit):");
            //    int input = int.Parse(Console.ReadLine());
            //    if (input % 2 == 0)
            //    {
            //        break;
            //    }
            //}

            //    for(int i = 0; i<10;i++)
            //    {
            //        Console.WriteLine("Out");
            //        for(int j =0; j<10;j++)
            //        {
            //            Console.WriteLine("In");
            //            goto doNotUse;
            //        }
            //    }
            //doNotUse:
            //        Console.WriteLine("Out of Loop");

            //for(int i = 1; i <10; i++)
            //{
            //    if(i %2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //string input = "Wai Yan Naung";
            ////Console.WriteLine(input.ToUpper());
            ////Console.WriteLine(input.ToLower());

            //string[] arr = input.Split(new char[] { ' ' });
            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string inp = " Wai Yan Naung            \n";
            //Console.WriteLine("::" + inp.Trim() + "::");
            //Console.Read();

            //string[] arr = { "A", "B", "C", "D", "E" };
            //Console.WriteLine(string.Join(",", arr));

            //Console.WriteLine("Before");
            //Console.SetCursorPosition(5, 5);
            //Console.WriteLine("After");

            //Console.WriteLine("Out 1");
            //Thread.Sleep(1000);
            //Console.WriteLine("Out 2");
            //Thread.Sleep(1000);
            //Console.WriteLine("Out 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Out 4");
            //Thread.Sleep(1000);
            //Console.WriteLine("Out 5");

            //int x = 1;
            //while (x < 50)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 5);

            //    if (x % 3 == 0)
            //    {
            //        Console.WriteLine("__@");
            //    }
            //    else if(x % 3 == 1)
            //    {
            //        Console.WriteLine("_^@");
            //    }
            //    else
            //    {
            //        Console.WriteLine("^_@");
            //    }
            //    x++;
            //    Thread.Sleep(500);
            //}

            bool state = true;
            while (state)
            {
                ConsoleKeyInfo Info = Console.ReadKey();
                switch (Info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up Arrow");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down Arrow");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left Arrow");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right Arrow");
                        break;
                    default:
                        Console.WriteLine("Other Key");
                        state = false;
                        break;
                }
            }
        }
    }
}
