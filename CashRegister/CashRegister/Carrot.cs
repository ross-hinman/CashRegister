using System;
namespace CashRegister
{
    public class Carrot : Produce, IItem
    {
        
        public Carrot()
        {
            Name = "Carrot";
            Price = (1.49 * GetWeight());
            Code = 'c';
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
