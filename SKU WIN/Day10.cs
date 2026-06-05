//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SKU_WIN
//{
//    class Animal
//    {
//        public int age;

//        public Animal()
//        {
//            this.age = 0;
//        }
//        public void Eat()
//        {
//            Console.WriteLine("Animal is eating.");
//        }

//        public void Sleep()
//        {
//            Console.WriteLine("Animal is sleeping.");
//        }

//    }
//    class Dog : Animal
//    {
//        //public string Color { get; set; }

//        public void Bark()
//        {
//            Console.WriteLine("Dog is barking.");
//        }

//        public void Test()
//        {
//            Eat();
//            Sleep();
//        }
//    }
//    class Cat : Animal
//    {
//        public void Meow()
//        {
//            Console.WriteLine("Cat is meowing.");
//        }
//    }
//    internal class Day10
//    {
//        public static void Main()
//        {
//            //Dog dog = new Dog();
//            //dog.Bark();
//            //dog.Eat();
//            //dog.Sleep();
//            //Cat cat = new Cat();
//            //cat.Meow();
//            //cat.Eat();
//            //cat.Sleep();

//            List<Animal> Animals = new List<Animal>()
//            {
//                new Dog(),
//                new Cat(),
//                new Dog(),
//                new Cat(),
//                new Dog(),
//                new Cat(),
//                new Dog(),
//            };
//            //foreach (var animal in Animals)
//            //{
//            //    animal.Eat();
//            //    animal.Sleep();
//            //}

//            ////---OBJECT CLASS-- -
//            ////NO need to reopen
//            ////List<Object> listOfObjectA = new List<Object>();
//            ////listOfObjectA.Add(new Dog());
//            ////listOfObjectA.Add(new Cat());

//            foreach (var obj in Animals)
//            {
//                if (obj is Dog)
//                {
//                    ((Dog)obj).Bark();
//                }
//                if (obj is Cat)
//                {
//                    ((Cat)obj).Meow();
//                }
//                var dog = obj as Dog;
//                if (dog != null)
//                {
//                    dog.Bark();
//                }

//                var cat = obj as Cat;
//                if (cat != null)
//                {
//                    cat.Meow();
//                }
//            }
//        }
//    }
//}
