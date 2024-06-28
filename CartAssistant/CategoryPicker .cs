using System;
using System.Collections.Generic;
using System.Linq;

namespace CartAssistant
{
    public class CategoryPicker
    {
        static readonly string itemRegex = @"^[1-5]$";
        static readonly string quantityRegex = @"^[1-9]\d*$";
        public static ICartManager operations = new CartManager();
        public static IList<CartItem> itemsInCart = operations.GetList();
        public static void Electronics()
        {
            MenuDisplay.ShowElectronicsMenu();
            string item = Console.ReadLine();
            if ((!UserInputValidator.ValidateUserInput(item, itemRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 5.\n");
                return;
            }

            ElectronicItem option = Enum.Parse<ElectronicItem>(item);

            if (itemsInCart?.Any(i => i.Name == option.ToString() && i.Quantity > 0) ?? false)
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
            if ((!UserInputValidator.ValidateUserInput(quantity, quantityRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value.\n");
                return;
            }

            switch (option)
            {
                case ElectronicItem.Laptop:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case ElectronicItem.MobilePhone:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case ElectronicItem.Tablet:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case ElectronicItem.HeadPhones:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case ElectronicItem.SmartWatch:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
            }
            Console.WriteLine($"\nOperation Succeeded: You've got the amount of {quantity} {option} successfully added to your ShopCart.");
        }
        public static void Home()
        {
            MenuDisplay.ShowHomeMenu();
            string item = Console.ReadLine();
            if ((!UserInputValidator.ValidateUserInput(item, itemRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 5.\n");
                return;
            }

            HomeItem option = Enum.Parse<HomeItem>(item);

            if (itemsInCart?.Any(i => i.Name == option.ToString() && i.Quantity > 0) ?? false)
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
            if ((!UserInputValidator.ValidateUserInput(quantity, quantityRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value.\n");
                return;
            }

            switch (option)
            {
                case HomeItem.VacuumCleaner:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case HomeItem.Sofa:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case HomeItem.TableLamp:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case HomeItem.Microwave:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case HomeItem.CoffeeMaker:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
            }
            Console.WriteLine($"\nOperation Succeeded: You've got the amount of {quantity} {option} successfully added to your ShopCart.");
        }
        public static void Clothing()
        {
            MenuDisplay.ShowClothingMenu();
            string item = Console.ReadLine();
            if ((!UserInputValidator.ValidateUserInput(item, itemRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 5.\n");
                return;
            }

            ClothingItem option = Enum.Parse<ClothingItem>(item);

            if (itemsInCart?.Any(i => i.Name == option.ToString() && i.Quantity > 0) ?? false)
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
            if ((!UserInputValidator.ValidateUserInput(quantity, quantityRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value.\n");
                return;
            }

            switch (option)
            {
                case ClothingItem.TShirt:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case ClothingItem.Pants:
                    operations.Add(option.ToString(), int.Parse(quantity));

                    break;
                case ClothingItem.Jacket:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case ClothingItem.Shoes:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case ClothingItem.Hat:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
            }
            Console.WriteLine($"\nOperation Succeeded: You've got the amount of {quantity} {option} successfully added to your ShopCart.");
        }
        public static void Sports()
        {
            MenuDisplay.ShowSportsMenu();
            string item = Console.ReadLine();
            if ((!UserInputValidator.ValidateUserInput(item, itemRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 5.\n");
                return;
            }

            SportsItem option = Enum.Parse<SportsItem>(item);

            if (itemsInCart?.Any(i => i.Name == option.ToString() && i.Quantity > 0) ?? false)
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
            if ((!UserInputValidator.ValidateUserInput(quantity, quantityRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value.\n");
                return;
            }

            switch (option)
            {
                case SportsItem.SoccerBall:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case SportsItem.TennisRacket:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case SportsItem.Bicycle:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case SportsItem.Dumbbells:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case SportsItem.Treadmill:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
            }
            Console.WriteLine($"\nOperation Succeeded: You've got the amount of {quantity} {option} successfully added to your ShopCart.");
        }
        public static void Kitchen()
        {
            MenuDisplay.ShowKitchenMenu();
            string item = Console.ReadLine();
            if ((!UserInputValidator.ValidateUserInput(item, itemRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 5.\n");
                return;
            }

            KitchenItem option = Enum.Parse<KitchenItem>(item);

            if (itemsInCart?.Any(i => i.Name == option.ToString() && i.Quantity > 0) ?? false)
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
            if ((!UserInputValidator.ValidateUserInput(quantity, quantityRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value.\n");
                return;
            }

            switch (option)
            {
                case KitchenItem.KnifeSet:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case KitchenItem.FryingPans:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case KitchenItem.Pots:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case KitchenItem.Blender:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case KitchenItem.Toaster:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
            }
            Console.WriteLine($"\nOperation Succeeded: You've got the amount of {quantity} {option} successfully added to your ShopCart.");
        }
        public static void Food()
        {
            MenuDisplay.ShowFoodMenu();
            string item = Console.ReadLine();
            if ((!UserInputValidator.ValidateUserInput(item, itemRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 5.\n");
                return;
            }

            FoodItem option = Enum.Parse<FoodItem>(item);

            if (itemsInCart?.Any(i => i.Name == option.ToString() && i.Quantity > 0) ?? false)
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
            if ((!UserInputValidator.ValidateUserInput(quantity, quantityRegex)))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value.\n");
                return;
            }

            switch (option)
            {
                case FoodItem.Rice:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case FoodItem.Noodles:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case FoodItem.OliveOil:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case FoodItem.Flour:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;
                case FoodItem.Sugar:
                    operations.Add(option.ToString(), int.Parse(quantity));
                    break;

            }
            Console.WriteLine($"\nOperation Succeeded: You've got the amount of {quantity} {option} successfully added over your ShopCart.");
        }
    }
}
