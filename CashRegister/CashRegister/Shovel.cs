namespace CashRegister
{
    internal class Shovel : Product, IItem
    {
        public Shovel()
        {
            Price = 19.99;
            Code = 'e';
        }

        public bool HasPrice { get; set; }
    }
}