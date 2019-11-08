namespace CashRegister
{
    internal class Milk : Product, IItem
    {
        public Milk()
        {
            Price = 2.99;
            Code = 'f';
        }

        public bool HasPrice { get; set; }
    }
}