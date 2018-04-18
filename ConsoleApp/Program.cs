using System;
using ShoppingCartLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCartService = new ShoppingCartService();
            shoppingCartService.AddCart(new MacBookPro());
            shoppingCartService.AddCart(new IPadAir());
            shoppingCartService.AddCart(new AppleWatch());
            shoppingCartService.AddCart(new AppleCombo());

            var result = shoppingCartService.CalculatePrice();
            Console.WriteLine("{0}", result);
        }
    }
}