using System;
using System.Collections.Generic;

namespace CartAssistant
{
    /*
      Hacer un programa que maneje la lista de artículos de un carrito de compra,
      donde se pueda agregar, eliminar y listar los elementos del carrito.

     -Requerimientos:
       Usar Interfaces para las operaciones de carrito.
       Usar colecciones para el manejo de los elementos del carrito.
       Usar diferentes clases para representar los elementos del programa.
       Si el usuario quiere agregar un artículo repetido, preguntarle si quiere aumentar la cantidad de ese artículo.
       Manejar cantidades del articulo al momento de agregarlo.

     -Opciones del menu:
       1. Agregar artículos.
       2. Ver lista de artículos.
       3. Administrar artículos.
           1) Cambiar cantidades de un artículo.
           2) Eliminar artículos.
     */
    internal class Program
    {
        public static bool exitRequested = false;
        static void Main()
        {
            do
            {
                MenuDisplay.ShowMainMenu();
                UserInputValidator.VerifyUserInput();
            } while (!exitRequested);
        }
        public static void HandleMenuSelection(string userInput)
        {
            MenuOption option = Enum.Parse<MenuOption>(userInput);

            switch (option)
            {
                case MenuOption.AddArticles:
                    HandleAddition();
                    break;
                case MenuOption.ShowList:
                    HandleCartDisplay();
                    break;
                case MenuOption.ManageArticles:
                    HandleCartManage();
                    break;
                case MenuOption.Exit:
                    HandleLogOut();
                    break;
            }
            Console.WriteLine();
        }
        public static void HandleAddition()
        {
            MenuDisplay.ShowCategoriesMenu();
            string userInput = Console.ReadLine();
            if ((!UserInputValidator.ValidateUserInput(userInput, @"^[1-6]$")))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 6.");
                return;
            }

            Categories option = Enum.Parse<Categories>(userInput);

            var categoryActions = new Dictionary<Categories, (Type type, Action showMenu)>
            {
            { Categories.Electronics, (typeof(ElectronicItem), MenuDisplay.ShowElectronicsMenu) },
            { Categories.Home, (typeof(HomeItem), MenuDisplay.ShowHomeMenu) },
            { Categories.Clothing, (typeof(ClothingItem), MenuDisplay.ShowClothingMenu) },
            { Categories.Sports, (typeof(SportsItem), MenuDisplay.ShowSportsMenu) },
            { Categories.Kitchen, (typeof(KitchenItem), MenuDisplay.ShowKitchenMenu) },
            { Categories.Food, (typeof(FoodItem), MenuDisplay.ShowFoodMenu) }
            };

            CategoryPicker.Category(categoryActions[option].type, categoryActions[option].showMenu);
        }
        public static void HandleCartDisplay()
        {
            Console.WriteLine("MY CART ITEMS:");
            for (int i = 0; i < CategoryPicker.itemsInCart.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {CategoryPicker.itemsInCart[i].Quantity} " +
                $"{CategoryPicker.itemsInCart[i].Name}.");
            }
            Console.WriteLine("----------------------------------------------");

            if (CategoryPicker.itemsInCart.Count == 0) Console.WriteLine("Nothing has been picked up yet, cart is empty.");
        }
        public static void HandleCartManage()
        {
            MenuDisplay.ShowMenuManagment();
            string input = Console.ReadLine();
            if (input != "1" && input != "2")
            {
                Console.WriteLine("\nInvalid Input. Please enter a valid numeric value.");
                return;
            }

            MenuManagment option = Enum.Parse<MenuManagment>(input);
            HandleCartDisplay();

            switch (option)
            {
                case MenuManagment.Edit:
                    HandleEdit();
                    break;
                case MenuManagment.Remove:
                    HandleRemove();
                    break;
            }

            void HandleEdit()
            {
                if (CategoryPicker.itemsInCart.Count == 0)
                {
                    Console.WriteLine("Nothing to be updated, cart is empty.");
                    return;
                }

                Console.WriteLine("\nWhich item would you like to update the amount of?");
                string index = Console.ReadLine();
                if ((!UserInputValidator.ValidateUserInput(index, @"^[1-9]\d*$")))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid numeric value.");
                    return;
                }

                var userChoice = int.Parse(index);
                if (userChoice <= 0 || userChoice > CategoryPicker.itemsInCart.Count)
                {
                    Console.WriteLine("\nInvalid Input. That item doesn't exist in this Matrix");
                    return;
                }

                Console.WriteLine("\nWhich is the new amount?");
                string quantity = Console.ReadLine();
                if ((!UserInputValidator.ValidateUserInput(quantity, @"^[1-9]\d*$")))
                {
                    Console.WriteLine("\nInvalid Input. Please enter a valid numeric value.");
                    return;
                }

                var updatedItem = CategoryPicker.itemsInCart[userChoice - 1];
                CategoryPicker.operations.Edit(userChoice - 1, int.Parse(quantity));
                Console.WriteLine($"Operation Succeeded: The item {updatedItem.Name} in your cart has been successfully updated to a new amount of {quantity}.");
            }

            void HandleRemove()
            {
                if (CategoryPicker.itemsInCart.Count == 0)
                {
                    Console.WriteLine("Nothing to be removed, cart is empty.");
                    return;
                }

                Console.WriteLine("\nWhich item would you like to remove?");
                string index = Console.ReadLine();
                if ((!UserInputValidator.ValidateUserInput(index, @"^[1-9]\d*$")))
                {
                    Console.WriteLine("\nInvalid Input. Please enter a valid numeric value.");
                    return;
                }

                var userChoice = int.Parse(index);
                if (userChoice <= 0 || userChoice > CategoryPicker.itemsInCart.Count)
                {
                    Console.WriteLine("\nInvalid Input. That item doesn't exist in this Matrix");
                    return;
                }

                var removedItem = CategoryPicker.itemsInCart[userChoice - 1];
                CategoryPicker.operations.Remove(userChoice - 1);
                Console.WriteLine($"Operation Succeeded: {removedItem.Quantity} {removedItem.Name} has been successfully removed.");
            }
        }
        public static void HandleLogOut()
        {
            string input;
            do
            {
                Console.WriteLine("Are you sure you want to log out?\n1. YES / 2. NO");
                input = Console.ReadLine();
                Console.WriteLine();
            }
            while (input != "1" && input != "2");

            if (input == "1")
            {
                Console.WriteLine("Logging out...\nThank you for using our services. You have a great day!");
                exitRequested = true;
            }
            return;
        }
    }
}
