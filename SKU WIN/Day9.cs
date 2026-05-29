//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SKU_WIN
//{
//    class Day9
//    {
//        //class Product
//        //{
//        //    public static int count = 0;
//        //    public int id;
//        //    public string name;
//        //    public int price;

//        //    public Product(string name, int price)
//        //    {
//        //        this.id = ++count;
//        //        this.name = name;
//        //        this.price = price;
//        //    }
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Product product1 = new Product("Laptop", 50000);
//        //    Product product2 = new Product("Phone", 20000);
//        //    Product product3 = new Product("Tablet", 30000);
//        //    Console.WriteLine("Product ID: " + product1.id + "\tName: " + product1.name + "\tPrice: " + product1.price);
//        //    Console.WriteLine("Product ID: " + product2.id + "\tName: " + product2.name + "\tPrice: " + product2.price);
//        //    Console.WriteLine("Product ID: " + product3.id + "\tName: " + product3.name + "\tPrice: " + product3.price);
//        //}

//        //class Product
//        //{
//        //    public string name;
//        //    public int price;

//        //    public Product(string name, int price)
//        //    {
//        //        this.name = name;
//        //        this.price = price;
//        //    }
//        //    ~Product()
//        //    {
//        //        Console.WriteLine("Destructor called for product: " + name);
//        //    }
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Product product1 = new Product("Laptop", 50000);
//        //}

//        //class Product
//        //{
//        //    private static int count;
//        //    public readonly int id;
//        //    public string name;
//        //    public int price;

//        //    public Product(string name, int price)
//        //    {
//        //        this.id = ++count;
//        //        this.name = name;
//        //        this.price = price;
//        //    }
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Product product1 = new Product("Laptop", 50000);
//        //    Product product2 = new Product("Phone", 20000);
//        //    Product product3 = new Product("Tablet", 30000);
//        //    Console.WriteLine("Product ID: " + product1.id + "\tName: " + product1.name + "\tPrice: " + product1.price);
//        //    Console.WriteLine("Product ID: " + product2.id + "\tName: " + product2.name + "\tPrice: " + product2.price);
//        //    Console.WriteLine("Product ID: " + product3.id + "\tName: " + product3.name + "\tPrice: " + product3.price);
//        //}

//        //class Box
//        //{
//        //    private int width;
//        //    private int height;

//        //    public Box(int width, int height)
//        //    {
//        //        if (width > 0 && height > 0)
//        //        {
//        //            this.width = width;
//        //            this.height = height;
//        //        }
//        //        else
//        //        {
//        //            throw new ArgumentException("Width and Height must be positive integers.");
//        //        }
//        //    }

//        //    public int Area()
//        //    {
//        //        return this.width * this.height;
//        //    }

//        //    public int GetWidth()
//        //    {
//        //        return width;
//        //    }
//        //    public int GetHeight()
//        //    {
//        //        return height;
//        //    }

//        //    public void SetWidth(int width)
//        //    {
//        //        if (width > 0)
//        //            this.width = width;
//        //        else
//        //            throw new ArgumentException("Width must be a positive integer.");
//        //    }

//        //    public void SetHeight(int height)
//        //    {
//        //        if (height > 0)
//        //            this.height = height;
//        //        else
//        //            throw new ArgumentException("Height must be a positive integer.");
//        //    }
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Box box = new Box(5, 10);
//        //    Console.WriteLine("Box Area: " + box.Area());
//        //    Console.WriteLine("Box Width: " + box.GetWidth());
//        //    Console.WriteLine("Box Height: " + box.GetHeight());
//        //    box.SetWidth(7);
//        //    box.SetHeight(3);
//        //    Console.WriteLine("Updated Box Area: " + box.Area());
//        //    Console.WriteLine("Updated Box Width: " + box.GetWidth());
//        //    Console.WriteLine("Updated Box Height: " + box.GetHeight());
//        //}

//        //class Box
//        //{
//        //    //private int width;
//        //    public int width
//        //    {
//        //        get { return width; }
//        //        set
//        //        {
//        //            if (value > 0)
//        //                width = value;
//        //            else
//        //                throw new ArgumentException("Width must be a positive integer.");
//        //        }
//        //    }
//        //    //private int height;
//        //    public int height
//        //    {
//        //        get { return height; }
//        //        set
//        //        {
//        //            if (value > 0)
//        //                height = value;
//        //            else
//        //                throw new ArgumentException("Height must be a positive integer.");
//        //        }
//        //    }
//        //    public Box(int width, int height)
//        //    {
//        //        width = width;
//        //        height = height;
//        //    }
//        //    public int Area()
//        //    {
//        //        return this.width * this.height;
//        //    }
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Box box = new Box(5, -10);
//        //    box.width = 7;
//        //    box.height = 7;
//        //    Console.WriteLine("Box Area: " + box.Area());
//        //    Console.WriteLine("Box Width: " + box.width);
//        //    Console.WriteLine("Box Height: " + box.height);
//        //}

//    }
//}