using System;
using System.Collections.Generic;

namespace CashRegister
{
    public class Cart
    {
        public List<Product> ShoppingCart { get; set; }

        public Cart()
        {
            ShoppingCart = new List<Product>();
        }

        public void Run()
        {
            Console.Clear();
            PrintMenu();
            Console.WriteLine("Choose a key of a product you would like to purchase:");
            char item = Console.ReadKey().KeyChar;

            if (item == 'x')
            {
                Console.WriteLine($"Your total is ${Checkout()}");
            }
            else
            {
                AddItem(item);
                Run();
            }
        }

        public void AddItem(char x)
        {
            switch (x)
            {
                case 'a':
                    var apple = new Apple();
                    Console.WriteLine("Please enter a weight: (lbs)");
                    apple.Weight = Convert.ToDouble(Console.ReadLine());
                    ShoppingCart.Add(apple);
                    break;
                case 'b':
                    var banana = new Banana();
                    Console.WriteLine("Please enter a weight: (lbs)");
                    banana.Weight = Convert.ToDouble(Console.ReadLine());
                    ShoppingCart.Add(banana);
                    break;
                case 'c':
                    var carrot = new Carrot();
                    Console.WriteLine("Please enter a weight: (lbs)");
                    carrot.Weight = Convert.ToDouble(Console.ReadLine());
                    ShoppingCart.Add(carrot);
                    break;
                case 'd':
                    var battery = new Battery();
                    ShoppingCart.Add(battery);
                    break;
                case 'e':
                    var shovel = new Shovel();
                    ShoppingCart.Add(shovel);
                    break;
                case 'f':
                    var milk = new Milk();
                    ShoppingCart.Add(milk);
                    break;
                default:
                    Console.WriteLine("Incorrect Key, Please try again!");
                    break;
            }
        }
        public double Checkout()
        {
            double total = 0;
            foreach(Product x in ShoppingCart)
            {
                total = total + x.Price;
            }
            return total;
        }
        public void PrintMenu()
        {
            string menu1 = "-------------------------------------";
            string menu2 = "|  Item               Price    Key  |";
            string menu3 = "|  Apple             $00.00     a   |";
            string menu4 = "|  Banana            $00.00     b   |";
            string menu5 = "|  Carrot            $00.00     c   |";
            string menu6 = "|  Battery           $00.00     d   |";
            string menu7 = "|  Shovel            $00.00     e   |";
            string menu8 = "|  Milk              $00.00     f   |";
            string menu9 = "-------------------------------------";
            string menu0 = "Press 'x' to finish and checkout.";
            Console.WriteLine($"{menu1}\n{menu2}\n{menu3}\n{menu4}\n{menu5}\n{menu6}\n{menu7}\n{menu8}\n{menu9}\n{menu0}");
        }
    }
}
