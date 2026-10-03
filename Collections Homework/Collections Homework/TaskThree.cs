using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Homework
{
    internal class TaskThree
    {
        LinkedList<string> names = new LinkedList<string>();
        public void TaskLoop()
        {
            while (true)
            {
                Console.WriteLine("Enter 3-6 female names and type '-done' when ready or enter '-exit' to return to the main menu: ");
                while (names.Count < 6)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    while (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Invalid input. Please enter a name.");
                        name = Console.ReadLine();
                    }
                    if (name == "-exit") return;
                    if (name == "-done")
                    {
                        if (names.Count < 3)
                        {
                            Console.WriteLine($"You need to enter at least 3 names. Current number of names is {names.Count}.");
                            continue;
                        }
                        break;
                    }
                    names.AddLast(name);
                }
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine();
                foreach (string name in names.Reverse())
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Would you like to repeat? Type 'yes' or 'no'.");
                string choice = Console.ReadLine();
                while (choice != "yes" && choice != "no")
                {
                    Console.WriteLine("Invalid input. Try again.");
                    choice = Console.ReadLine();
                }
                if (choice == "yes")
                {
                    names.Clear();
                }
                else if (choice == "no")
                {
                    return;
                }
            }
        }
    }
}