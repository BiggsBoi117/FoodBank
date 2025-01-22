using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBank
{
    internal class Interface
    {
        public static void Main()
        {
            //Don't let the user enter a non-number
            while (true)
            {
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }
            }
        }
    }
}
