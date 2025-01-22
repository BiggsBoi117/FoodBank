using FoodBank;

//Initialize program
Console.WriteLine("Program Loading...");

//Initialize variables
List<FoodItem> bankMemory = new List<FoodItem>();
int userChoice = 0; 

//Handle user input
while (userChoice != 6) 
{
    //Print the menu
    Console.Clear();
    Console.WriteLine("\nWelcome to the C# FoodBank!");
    Console.WriteLine("1. Add food item");
    Console.WriteLine("2. Delete food item");
    Console.WriteLine("3. Print food items");
    Console.WriteLine("4. Show expired food items");
    Console.WriteLine("5. Edit food items");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice (1-6): ");

    while (true)
    {
        try
        {
            string choice = Console.ReadLine();
            userChoice = int.Parse(choice);
            break;
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        }
    }
    switch (userChoice)
    {
        case 1: //Add food item
            //Get user input
            Console.WriteLine("Enter the name of the food item: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the category of the food item: ");
            string category = Console.ReadLine();

            Console.WriteLine("Enter the quantity of the food item: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the expiration date of the food item (YYYY-MM-DD): ");
            DateTime expirationDate = DateTime.Parse(Console.ReadLine());

            //Add the food item to the bank
            BankTools.AddFoodItem(bankMemory, name, category, quantity, expirationDate);

            break;

        case 2: //Delete food item
            //Get user input about the index of the food item to delete
            for (int i = 0; i < bankMemory.Count; i++) 
            { 
                Console.WriteLine($"{i + 1}. {bankMemory[i].Name}"); 
            }
                
            Console.WriteLine("Enter the index of the food item to delete (or 0 to cancel): ");
            int index = int.Parse(Console.ReadLine());
            index -= 1;

            if ((index < 0 && index != -1) || index >= bankMemory.Count)
            {
                Console.WriteLine("Invalid index. Please enter a number between 1 and " + bankMemory.Count + ".");
                break;
            }
            else if (index >= 0 && index < bankMemory.Count)
            {
                bankMemory = BankTools.DeleteFoodItem(bankMemory, index);
            }
            else if (index == -1)
            {
                break;
            }            

            break;

        case 3: //Print food items
            BankTools.PrintFoodItems(bankMemory);

            break;

        case 4: //Show expired food items
            BankTools.ShowExpiredItems(bankMemory);

            break;

        case 5: //Edit food items
            //Get user input about the index of the food item to edit
            for (int i = 0; i < bankMemory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bankMemory[i].Name}");
            }

            Console.WriteLine("Enter the index of the food item to edit (or 0 to cancel): ");
            index = int.Parse(Console.ReadLine());
            index -= 1;

            if ((index < 0 && index != -1) || index >= bankMemory.Count)
            {
                Console.WriteLine("Invalid index. Please enter a number between 1 and " + bankMemory.Count + ".");
                break;
            }
            else if (index >= 0 && index < bankMemory.Count)
            {
                BankTools.EditFoodItem(bankMemory[index]);
            }
            else if (index == -1)
            {
                break;
            }

            break;

        case 6: //Exit
            Console.WriteLine("\nGoodbye!");

            break;

        default: //Invalid choice
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            break;
    }
    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
}