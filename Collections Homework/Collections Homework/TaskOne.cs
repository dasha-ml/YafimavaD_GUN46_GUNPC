using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Homework
{
    public class TaskOne
    {
        List<string> _berries = new List<string> { "Strawberry", "Raspberry", "Black Currant" };

        public void TaskLoop()
        {
            while (true)
            {
                Console.WriteLine("Write a name of a berry or write '-exit' to return to the menu: ");
                string choice = Console.ReadLine()!;

                if (choice == "-exit")
                {
                    return;
                }

                while (string.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("Invalid input. Try again!");
                    choice = Console.ReadLine();
                    if (choice == "-exit") return;
                }
                string newBerry = choice;
                _berries.Add(newBerry);
                Console.WriteLine($"List of berries: {string.Join(",", _berries)}");

                Console.WriteLine("Write one more name of a berry or write '-exit' to return to the main menu: ");
                string secondBerry = Console.ReadLine();
                if (secondBerry == "-exit")
                {
                    return;
                }
                while (string.IsNullOrEmpty(secondBerry))
                {
                    Console.WriteLine("You did not enter a valid name. Try again!");
                    secondBerry = Console.ReadLine();
                    if (secondBerry == "-exit") return;
                }
                _berries.Insert(_berries.Count / 2, secondBerry);
                Console.WriteLine($"Updated list of berries: {string.Join(",", _berries)}");
            }
        }
    }
}