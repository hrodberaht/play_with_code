using System;
using mag.models;

namespace mag
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p1 = Product.createProduct("1");   
            Console.WriteLine(p1);
            Product p2 = Product.createProduct("2");
            Console.WriteLine(p2);
            Console.WriteLine("----------");
            Console.WriteLine("Hello");
            Console.WriteLine("----------");
            Console.WriteLine(p1._name);
            Console.WriteLine(p2._name);
            Console.WriteLine("----------");
            p1 = null;
            Product p3 = Product.createProduct("3");
            Console.WriteLine(p3._name);
            

        }
    }
}
