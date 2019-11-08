using System;
namespace CashRegister
{
    public class Carrot : Produce, IItem
    {
        public Carrot()
        {
            Price = (1.49 * this.Weight);
            Code = 'c';
        }

        public bool HasPrice { get; set; }
    }
}
