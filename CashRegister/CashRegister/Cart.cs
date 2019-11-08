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
            foreach(Product product in ShoppingCart)
                Console.WriteLine($"{product.Name} = ${product.Price}");
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

        /// <summary>
        /// Takes input and adds item to cart List
        /// </summary>
        /// <param name="x">Input key</param>
        public void AddItem(char x)
        {
            switch (x)
            {
                case 'a':
                    var apple = new Apple();
                    ShoppingCart.Add(apple);
                    break;
                case 'b':
                    var banana = new Banana();
                    ShoppingCart.Add(banana);
                    break;
                case 'c':
                    var carrot = new Carrot();
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
                total += x.Price;
            }
            return total;
        }
        //this is a comment :)
        public void PrintMenu()
        {
            string menu1 = "-------------------------------------";
            string menu2 = "|  Item               Price    Key  |";
            string menu3 = "|  Apple             $2.99/lb   a   |";
            string menu4 = "|  Banana            $1.99/lb   b   |";
            string menu5 = "|  Carrot            $1.49/lb   c   |";
            string menu6 = "|  Battery           $9.99      d   |";
            string menu7 = "|  Mike's Shovel     $19.99     e   |";
            string menu8 = "|  Milk              $2.99      f   |";
            string menu9 = "-------------------------------------";
            string menu0 = "Press 'x' to finish and checkout.";
            Console.WriteLine($"{menu1}\n{menu2}\n{menu3}\n{menu4}\n{menu5}\n{menu6}\n{menu7}\n{menu8}\n{menu9}\n{menu0}");
        }
    }
}
