using System;
namespace CashRegister
{
    public class Banana : Produce, IItem
    {
        
        public Banana()
        {
            Price = (1.99 * GetWeight());
            Code = 'b';
            Name = "Banana";
        }

        public bool HasPrice { get; set; }

        public double GetWeight()
        {
            Console.WriteLine("Please enter a weight: (lbs)");
            double weight = Convert.ToDouble(Console.ReadLine());
            return weight;
        }
    }
}
