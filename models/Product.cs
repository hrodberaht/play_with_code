using System;

namespace mag.models
{
    public class Product
    {
        string _name;
        public Product(int i)
        {   
            Console.WriteLine("The number is: " + i + " and Name: " + _name);
        }

        public void setName(string name)
        {
            _name = name;
        }
    }
}