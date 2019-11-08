using System;
namespace CashRegister
{
    public class Product : IItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Code { get; set; }

        public Product()
        {
        }
       
    }
}
