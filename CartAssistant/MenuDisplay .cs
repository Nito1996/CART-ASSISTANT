using System;

namespace CartAssistant
{
    public enum MenuOption
    {
        AddArticles = 1,
        ShowList,
        ManageArticles,
        Exit
    }
    public enum MenuManagment
    {
        Edit = 1,
        Remove
    }
    public enum Categories
    {
        Electronics = 1,
        Home,
        Clothing,
        Sports,
        Kitchen,
        Food
    }
    public enum ElectronicItem
    {
        Laptop = 1, MobilePhone, Tablet, HeadPhones, SmartWatch
    }
    public enum HomeItem
    {
        VacuumCleaner = 1, Sofa, TableLamp, Microwave, CoffeeMaker
    }
    public enum ClothingItem
    {
        TShirt = 1, Pants, Jacket, Shoes, Hat
    }
    public enum SportsItem
    {
        SoccerBall = 1, TennisRacket, Bicycle, Dumbbells, Treadmill
    }
    public enum KitchenItem
    {
        KnifeSet = 1, FryingPans, Pots, Blender, Toaster
    }
    public enum FoodItem
    {
        Rice = 1, Noodles, OliveOil, Flour, Sugar
    }
    public class MenuDisplay
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("Welcome to your favourite smart market CartAssistant!\nWhich action would you like to perform today?\n");
            Console.WriteLine($"1. {MenuOption.AddArticles}");
            Console.WriteLine($"2. {MenuOption.ShowList}");
            Console.WriteLine($"3. {MenuOption.ManageArticles}");
            Console.WriteLine($"4. {MenuOption.Exit}\n");
        }
        public static void ShowMenuManagment()
        {
            Console.WriteLine("Which action would you like to perform?\n");
            Console.WriteLine($"1. {MenuManagment.Edit}");
            Console.WriteLine($"2. {MenuManagment.Remove}\n");
        }
        public static void ShowCategoriesMenu()
        {
            Console.WriteLine("Which category are you looking for?\n");
            Console.WriteLine($"1. {Categories.Electronics}");
            Console.WriteLine($"2. {Categories.Home}");
            Console.WriteLine($"3. {Categories.Clothing}");
            Console.WriteLine($"4. {Categories.Sports}");
            Console.WriteLine($"5. {Categories.Kitchen}");
            Console.WriteLine($"6. {Categories.Food}\n");
        }
        public static void ShowElectronicsMenu()
        {
            Console.WriteLine("Which item would you like to pick up?\n");
            Console.WriteLine($"1. {ElectronicItem.Laptop}");
            Console.WriteLine($"2. {ElectronicItem.MobilePhone}");
            Console.WriteLine($"3. {ElectronicItem.Tablet}");
            Console.WriteLine($"4. {ElectronicItem.HeadPhones}");
            Console.WriteLine($"5. {ElectronicItem.SmartWatch}\n");
        }
        public static void ShowHomeMenu()
        {
            Console.WriteLine("Which item would you like to pick up?\n");
            Console.WriteLine($"1. {HomeItem.VacuumCleaner}");
            Console.WriteLine($"2. {HomeItem.Sofa}");
            Console.WriteLine($"3. {HomeItem.TableLamp}");
            Console.WriteLine($"4. {HomeItem.Microwave}");
            Console.WriteLine($"5. {HomeItem.CoffeeMaker}\n");
        }
        public static void ShowClothingMenu()
        {
            Console.WriteLine("Which item would you like to pick up?\n");
            Console.WriteLine($"1. {ClothingItem.TShirt}");
            Console.WriteLine($"2. {ClothingItem.Pants}");
            Console.WriteLine($"3. {ClothingItem.Jacket}");
            Console.WriteLine($"4. {ClothingItem.Shoes}");
            Console.WriteLine($"5. {ClothingItem.Hat}\n");
        }
        public static void ShowSportsMenu()
        {
            Console.WriteLine("Which item would you like to pick up?\n");
            Console.WriteLine($"1. {SportsItem.SoccerBall}");
            Console.WriteLine($"2. {SportsItem.TennisRacket}");
            Console.WriteLine($"3. {SportsItem.Bicycle}");
            Console.WriteLine($"4. {SportsItem.Dumbbells}");
            Console.WriteLine($"5. {SportsItem.Treadmill}\n");
        }
        public static void ShowKitchenMenu()
        {
            Console.WriteLine("Which item would you like to pick up?\n");
            Console.WriteLine($"1. {KitchenItem.KnifeSet}");
            Console.WriteLine($"2. {KitchenItem.FryingPans}");
            Console.WriteLine($"3. {KitchenItem.Pots}");
            Console.WriteLine($"4. {KitchenItem.Blender}");
            Console.WriteLine($"5. {KitchenItem.Toaster}\n");
        }
        public static void ShowFoodMenu()
        {
            Console.WriteLine("Which item would you like to pick up?\n");
            Console.WriteLine($"1. {FoodItem.Rice}");
            Console.WriteLine($"2. {FoodItem.Noodles}");
            Console.WriteLine($"3. {FoodItem.OliveOil}");
            Console.WriteLine($"4. {FoodItem.Flour}");
            Console.WriteLine($"5. {FoodItem.Sugar}\n");
        }
    }
}
