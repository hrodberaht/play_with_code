using System;

namespace mag.models
{
    public sealed class Product
    {
        private static Product _obj;
        public string _name { get; set; }
        private Product(string i)
        {   
            _name = i;
            Console.WriteLine("The number is: " + i + " and Name: ");
        }

        public void setName(string name)
        {
            _name = name;
        }

        public static Product createProduct(string id)
        {
            if(_obj != null)
                return _obj;
    
            return _obj = new Product(id);
        }
    }
}