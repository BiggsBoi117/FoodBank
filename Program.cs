using FoodBank;

Console.WriteLine("Welcome to the C# FoodBank!");
Console.WriteLine("1. Add food item");
Console.WriteLine("2. Delete food item");
Console.WriteLine("3. Print food items");
Console.WriteLine("4. Exit");
Console.Write("Enter your choice (1-4): ");

while (true) //Don't let the user enter a non-number
{
    try {
        int choice = int.Parse(Console.ReadLine());
        break;
    }
    catch { 
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
    }
}
