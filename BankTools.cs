using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoodBank
{
    internal class BankTools
    {
        public BankTools() { }

        public static List<FoodItem> AddFoodItem(List<FoodItem> bankMemory, string name, string category, int quantity, DateTime expirationDate)
        {
            bankMemory.Add(new FoodItem(name, category, quantity, expirationDate));
            return bankMemory;
        }

        public static List<FoodItem> DeleteFoodItem(List<FoodItem> bankMemory, int index)
        {
            bankMemory.RemoveAt(index);
            return bankMemory;
        }

        public static void PrintFoodItems(List<FoodItem> bankMemory)
        {
            if (bankMemory.Count == 0)
            {
                Console.WriteLine("\nThe food bank is empty.");
            }
            else
            {
                Console.WriteLine("\nFood Items:");
                foreach (FoodItem foodItem in bankMemory)
                {
                    Console.WriteLine($"Name: {foodItem.Name}, Category: {foodItem.Category}, Quantity: {foodItem.Quantity}, Expiration Date: {foodItem.ExpirationDate}");
                }
            }
        }

        public static void ShowExpiredItems(List<FoodItem> bankMemory)
        {
            Console.WriteLine("\nExpired Items:");
            foreach (FoodItem foodItem in bankMemory)
            {
                if (foodItem.ExpirationDate < DateTime.Now)
                {
                    Console.WriteLine($"Name: {foodItem.Name}, Category: {foodItem.Category}, Quantity: {foodItem.Quantity}, Expiration Date: {foodItem.ExpirationDate}");
                }
            }
        }

        public static void EditFoodItem(FoodItem foodItem)
        {
            //Display current attributes
            Console.WriteLine($"Current attributes of {foodItem.Name}:");
            Console.WriteLine($"1. Name: {foodItem.Name}");
            Console.WriteLine($"2. Category: {foodItem.Category}");
            Console.WriteLine($"3. Quantity: {foodItem.Quantity}");
            Console.WriteLine($"4. Expiration Date: {foodItem.ExpirationDate}");

            //Get user input
            bool goCondition = true;
            while (goCondition)
            {
                int index = 0;
                try
                {                  
                    Console.WriteLine("\nWhich attribute would you like to edit?");
                    index = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }

                switch (index)
                {
                    case 1:
                        Console.Write("Enter new name: ");
                        foodItem.Name = Console.ReadLine();
                        goCondition = false;
                        break;
                    case 2:
                        Console.Write("Enter new category: ");
                        foodItem.Category = Console.ReadLine();
                        goCondition = false;
                        break;
                    case 3:
                        Console.Write("Enter new quantity: ");
                        foodItem.Quantity = int.Parse(Console.ReadLine());
                        goCondition = false;
                        break;
                    case 4:
                        Console.Write("Enter new expiration date (YYYY-MM-DD): ");
                        foodItem.ExpirationDate = DateTime.Parse(Console.ReadLine());
                        goCondition = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("\nAttributes of {0} have been updated:", foodItem.Name);
            Console.WriteLine($"1. Name: {foodItem.Name}");
            Console.WriteLine($"2. Category: {foodItem.Category}");
            Console.WriteLine($"3. Quantity: {foodItem.Quantity}");
            Console.WriteLine($"4. Expiration Date: {foodItem.ExpirationDate}");
        }
    }
}
