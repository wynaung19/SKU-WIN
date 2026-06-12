//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SKU_WIN
//{
//    //class Wanted<T>
//    //{
//    //    public T Value;
//    //    public Wanted(T value)
//    //    {
//    //        this.Value = value;
//    //    }
//    //}

//    //class SquareCalc
//    //{
//    //    public int this[int i]
//    //    {
//    //        get { return i * i; }
//    //    }
//    //}
//    internal class Day12
//    {

//        //static void NextPos(int x,int y, int vx, int vy,out int rx, out int ry)
//        //{
//        //    rx = x+ vx; ry = y+vy;
//        //}

//        //struct Point
//        //{
//        //    public int x;
//        //    public int y;
//        //}

//        //struct Point
//        //{
//        //    public int x;
//        //    public int y;
//        //    public Point(int x, int y)
//        //    {
//        //        this.x = x;
//        //        this.y = y;
//        //    }
//        //}

//        class PointClass
//        {
//            public int x;
//            public int y;

//            public PointClass(int x, int y)
//            {
//                this.x = x;
//                this.y = y;
//            }
//        }
//        struct PointStruct
//        {
//            public int x;
//            public int y;

//            public PointStruct(int x, int y)
//            {
//                this.x = x;
//                this.y = y;
//            }
//        }
//        static void Main(string[] args)
//        {
//            //Wanted<string> wantedString = new Wanted<string>("String");
//            //Wanted<int> wantedInt = new Wanted<int>(52273);
//            //Wanted<double> wantedDouble = new Wanted<double>(52.273);

//            //Console.WriteLine(wantedString.Value);
//            //Console.WriteLine(wantedInt.Value);
//            //Console.WriteLine(wantedDouble.Value);

//            //SquareCalc sq = new SquareCalc();
//            //Console.WriteLine(sq[10]);

//            //Console.Write("Enter Number : ");
//            //int output;
//            //bool res = int.TryParse(Console.ReadLine(), out output);
//            //if (res)
//            //{
//            //    Console.WriteLine("NUM : " + output);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Enter NUMBER ONLY");
//            //}

//            //int x = 0;
//            //int y = 0;
//            //int vx = 1;
//            //int vy = 1;

//            //Console.WriteLine("Current : (" + x + "," + y + ")");
//            //NextPos(x,y,vx, vy,out x,out y);
//            //Console.WriteLine("NEXT : (" + x + "," + y + ")");

//            //Point point;
//            //point.x = 10;
//            //point.y = 10;

//            //Console.WriteLine(point.x);
//            //Console.WriteLine(point.y);

//            //Point point = new Point();
//            //Console.WriteLine(point.x);
//            //Console.WriteLine(point.y);

//            PointClass pointClassA = new PointClass(10, 20);
//            PointClass pointClassB = pointClassA;

//            pointClassB.x = 100;
//            pointClassB.y = 200;

//            Console.WriteLine("pointClassA: " + pointClassA.x + "," + pointClassA.y);
//            Console.WriteLine("pointClassB: " + pointClassB.x + "," + pointClassB.y);

//            Console.WriteLine();

//            PointStruct pointStructA = new PointStruct(10, 20);
//            PointStruct pointStructB = pointStructA;

//            pointStructB.x = 100;
//            pointStructB.y = 200;

//            Console.WriteLine("pointStructA: " + pointStructA.x + "," + pointStructA.y);
//            Console.WriteLine("pointStructB: " + pointStructB.x + "," + pointStructB.y);

//        }
//    }
//}