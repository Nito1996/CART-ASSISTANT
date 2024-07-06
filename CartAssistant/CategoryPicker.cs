using System;
using System.Collections.Generic;
using System.Linq;

namespace CartAssistant
{
    public class CategoryPicker
    {
        public static ICartManager operations = new CartManager();
        public static IList<CartItem> itemsInCart = operations.GetList();
        public static void Category(Type enumType, Action showMenu)
        {
            showMenu();
            string item = Console.ReadLine();
            if (!UserInputValidator.ValidateUserInput(item, @"^[1-5]$"))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 5.\n");
                return;
            }

            var option = Enum.Parse(enumType, item);
            if (itemsInCart.Any(i => i.Name == option.ToString()))
            {
                string input;
                do
                {
                    Console.WriteLine($"You have already picked up {option}, want to increase it though?\n1. YES / 2. NO");
                    input = Console.ReadLine();
                    Console.WriteLine();
                }
                while (input != "1" && input != "2");

                if (input == "2") return;
            }

            Console.WriteLine("Which is the amount you want to add?");
            string quantity = Console.ReadLine();
            if (!UserInputValidator.ValidateUserInput(quantity, @"^[1-9]\d*$"))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value.\n");
                return;
            }

            operations.Add(option.ToString(), int.Parse(quantity));
            Console.WriteLine($"\nOperation Succeeded: You've got the total amount in your ShopCart of " +
            $"{itemsInCart.FirstOrDefault(item => item.Name == option.ToString()).Quantity} {option} successfully added to your ShopCart.");
        }      
    }
}
