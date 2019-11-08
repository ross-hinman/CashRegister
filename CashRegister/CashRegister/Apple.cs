using System;
namespace CashRegister
{
    public class Apple : Produce, IItem
    {
        public Apple()
        {
            Price = (2.99 * this.Weight);
            Code = 'a';
        }

        public bool HasPrice { get; set; }
    }
}
