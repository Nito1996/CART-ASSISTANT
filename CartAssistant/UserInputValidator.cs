using System;
using System.Text.RegularExpressions;

namespace CartAssistant
{
    public class UserInputValidator
    {
        public static bool ValidateUserInput(string input, string regex)
        {
            return Regex.IsMatch(input, regex);
        }
        public static void VerifyUserInput()
        {
            string userInput = Console.ReadLine();
            if ((!ValidateUserInput(userInput, @"^[1-4]$")))
            {
                Console.WriteLine("Invalid Input. Please enter a valid numeric value from 1 to 4.\n");
                return;
            }
            Program.HandleMenuSelection(userInput);
        }
    }
}
