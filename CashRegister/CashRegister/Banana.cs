using System;
namespace CashRegister
{
    public class Banana : Produce, IItem
    {
        public Banana()
        {
            Price = (1.99 * this.Weight);
            Code = 'b';
        }

        public bool HasPrice { get; set; }
    }
}
