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

            string[] arr = { "A", "B", "C", "D", "E" };
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
