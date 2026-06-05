//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace SKU_WIN
//{
//    namespace A
//    {
//        class Parent
//        {
//            public Parent()
//            {
//                Console.WriteLine("Parent class constructor");
//            }
//        }
//        class Child : Parent
//        {
//            public Child()
//            {
//                Console.WriteLine("Child class constructor");
//            }
//        }
//    }
//    namespace B
//    {
//        class Parent
//        {
//            public Parent()
//            {
//                Console.WriteLine("Parent class constructor");
//            }
//        }
//        class Child : Parent
//        {
//            public Child() : base()
//            {
//                Console.WriteLine("Child");
//            }
//        }
//    }

//    namespace C
//    {
//        class Parent
//        {
//            public Parent()
//            {
//                Console.WriteLine("Parent()");
//            }
//            public Parent(int parm) { Console.WriteLine("Parent(int)"); }
//            public Parent(string parm) { Console.WriteLine("Parent(string)"); }
//        }
//        class Child : Parent
//        {
//            public Child(): base(10)
//            {
//                Console.WriteLine("Child base 10");
//            }
//            public Child(string input) : base(input)
//            {
//                Console.WriteLine("Child base input : " + input);
//            }
//        }
//    }
//    class Day11
//    {
//        //// Shadow And Hide
//        //public static int number = 10;

//        //class Parent
//        //{
//        //    public int varr = 237;
//        //    public void Method()
//        //    {
//        //        Console.WriteLine("ParentMethod");
//        //    }
//        //}
//        //class Child : Parent
//        //{
//        //    public string varr = "Shadow";
//        //    public void Method()
//        //    {
//        //        Console.WriteLine("ChildMethod");
//        //    }
//        //}

//        //// 7-6
//        //class Animal
//        //{
//        //    public void Eat()
//        //    {
//        //        Console.WriteLine("냠냠 먹습니다.");
//        //    }
//        //}
//        //class Dog : Animal
//        //{
//        //    public void Eat()
//        //    {
//        //        Console.WriteLine("강아지 사료를 먹습니다.");
//        //    }
//        //}
//        //class Cat : Animal
//        //{
//        //    public void Eat()
//        //    {
//        //        Console.WriteLine("고양이 사료를 먹습니다.");
//        //    }
//        //}

//        ////7-7
//        //class Animal
//        //{
//        //    public virtual void Eat()
//        //    {
//        //        Console.WriteLine("냠냠 먹습니다.");
//        //    }
//        //}
//        //class Dog : Animal
//        //{
//        //    public override void Eat()
//        //    {
//        //        Console.WriteLine("강아지 사료를 먹습니다.");
//        //    }
//        //}
//        //class Cat : Animal
//        //{
//        //    public override void Eat()
//        //    {
//        //        Console.WriteLine("고양이 사료를 먹습니다.");
//        //    }
//        //}

         
//    static void Main(string[] args)
//        {
//            //// A to C
//            //A.Child childA = new A.Child();
//            //Console.WriteLine();
//            //B.Child childB = new B.Child();
//            //Console.WriteLine();
//            //C.Child childC = new C.Child();
//            //C.Child cC = new C.Child("WaiYan");

//            //// Shadow And Hide
//            //int number = 20;
//            //Console.WriteLine(number);
//            //Console.WriteLine();

//            //Child ChildA = new Child();
//            //Console.WriteLine(ChildA.varr);

//            //Child ChildB = new Child();
//            //Console.WriteLine(((Parent)ChildB).varr);

//            //Child ChildC = new Child();
//            //ChildC.Method();
//            //((Parent)ChildC).Method();

//            ////7-6 + 7-7
//            //List<Animal> Animals = new List<Animal>()
//            //{
//            //    new Dog(), new Cat(), new Cat(), new Dog(),
//            //    new Dog(), new Cat(), new Dog(), new Dog()
//            //};
//            //foreach (var item in Animals)
//            //{
//            //    item.Eat();
//            //}


//        }
//    }
    
//}
