using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Homework
{
    internal class TaskThree
    {
        public class Node
        {
            public string Name { get; set; }
            public Node NextName;
            public Node PreviousName;
            public Node(string name)
            {
                Name = name;
            }
        }
        public Node Head;
        public Node Tail;
        public int Count { get; private set; }
        public void TaskLoop()
        {
            while (true)
            {
                Console.WriteLine("Enter 3-6 female names and type '-done' when ready or enter '-exit' to return to the main menu: ");
                while (Count < 6)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    while (string.IsNullOrEmpty(name))
                    {
                    Console.WriteLine("Invalid input. Please enter a name.");
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    }
                    if (name == "-exit") return;
                    if (name == "-done")
                    {
                        if (Count < 3)
                        {
                            Console.WriteLine($"You need to enter at least 3 names. Current number of names is {Count}.");
                            continue;
                        }
                        break;
                    }
                    Node newName = new Node(name);
                    if (Head == null)
                    {
                        Head = newName;
                        Tail = newName;
                    }
                    else
                    {
                        Tail.NextName = newName;
                        newName.PreviousName = Tail;
                        Tail = newName;
                    }
                    Count++;
                }
                Console.WriteLine("Direct Order:");
                Node current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.Name);
                    current = current.NextName;
                }
                Console.WriteLine();
                Console.WriteLine("Reverse Order:");
                Node reverse = Tail;
                while (reverse != null)
                {
                    Console.WriteLine(reverse.Name);
                    reverse = reverse.PreviousName;
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
                    Head = null;
                    Tail = null;
                    Count = 0;
                }
                else if (choice == "no")
                {
                    return;
                }
            }
        }
    }
}