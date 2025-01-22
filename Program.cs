using FoodBank;

//Initialize program
Console.WriteLine("Program Loading...");

//Print the menu
Console.WriteLine("Welcome to the C# FoodBank!");
Console.WriteLine("1. Add food item");
Console.WriteLine("2. Delete food item");
Console.WriteLine("3. Print food items");
Console.WriteLine("4. Exit");
Console.Write("Enter your choice (1-4): ");

//Handle user input
while (true)
{
    try
    {
        string choice = Console.ReadLine();
        int userChoice = int.Parse(choice);
        break;
    }
    catch
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
    }
}