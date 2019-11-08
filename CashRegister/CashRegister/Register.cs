using System;
namespace CashRegister
{
    public class Register
    {
        
        public void Run()
        {
            Console.Clear();
            PrintMenu();
            Console.WriteLine("Choose a key of a product you would like to purchase:");
            char item = Console.ReadKey().KeyChar;
            var cart = new Cart();
            if (item == 'x')
            {
                Console.WriteLine($"Your total is ${cart.Checkout()}");
            }
            else
            {
                cart.AddItem((char)item);
                Run();
            }            
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
