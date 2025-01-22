//Expand scope of program
using FoodBank;

//Initialize program
Console.WriteLine("Program Loading...");
try
{
    Interface ui = new Interface();
}
catch (Exception e)
{
    Console.WriteLine("Error Loading Program: " + e.Message);
}

//Print the menu
Console.WriteLine("Welcome to the C# FoodBank!");
Console.WriteLine("1. Add food item");
Console.WriteLine("2. Delete food item");
Console.WriteLine("3. Print food items");
Console.WriteLine("4. Exit");
Console.Write("Enter your choice (1-4): ");


