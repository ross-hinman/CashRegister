using System;
namespace CashRegister
{
    public class Battery : Product, IItem
    {
        
        public Battery()
        {
            Name = "Battery";
            Price = 9.99;
            Code = 'd';
        }

        public bool HasPrice { get; set; }
    }
}
