using System;
namespace CashRegister
{
    public class Apple : Produce, IItem
    {
        public Apple()
        {
            Price = (2.99 * GetWeight());
            Code = 'a';
            Name = "Apple";
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
