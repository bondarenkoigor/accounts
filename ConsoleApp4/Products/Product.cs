using System;

namespace ConsoleApp4.Products
{
    class Product
    {
        public float Price { get; protected set; }
        public string Name { get; protected set; }
        private Product() { Price = 0; Name = ""; }
        protected Product(float price) { Price = price; }
    }
}
