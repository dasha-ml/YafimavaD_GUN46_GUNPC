using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Homework
{
    internal class TaskTwo
    {
        private Dictionary<string, int> _marks = new Dictionary<string, int>();

        public void TaskLoop()
        {
            while (true)
            {
                Console.WriteLine("Enter student's surname or enter '-exit' to return to the main menu: ");
                string surname = Console.ReadLine();
                if (surname == "-exit")
                {
                    return;
                }
                while (string.IsNullOrWhiteSpace(surname) || (_marks.ContainsKey(surname)))
                {
                    if (string.IsNullOrWhiteSpace(surname))
                    {
                        Console.WriteLine("You enterned invalid surname. Try again!");
                        surname = Console.ReadLine();
                        if (surname == "-exit") return;
                    }
                    else
                    {
                        Console.WriteLine($"Student with {surname} surname already exists. Try to add a different student.");
                        surname = Console.ReadLine();
                        if (surname == "-exit") return;
                    }
                }
                Console.WriteLine($"Enter {surname}'s mark or enter '-exit' to return to the main menu: ");
                var input = Console.ReadLine();
                if (input == "-exit")
                {
                    return;
                }
                int mark;
                while (!int.TryParse(input, out mark) || mark < 2 || mark > 5)
                {
                    Console.WriteLine("You entered invalid mark. Try again!");
                    input = Console.ReadLine();
                    if (input == "-exit") return;
                };
                _marks.Add(surname, mark);

                Console.WriteLine("Enter student's name or enter '-exit' to return to the main menu: ");
                string newSurname = Console.ReadLine();
                if (newSurname == "-exit")
                {
                    return;
                }
                while (string.IsNullOrEmpty(newSurname))
                {
                    Console.WriteLine("You entered invalid surname. Try again!");
                    newSurname = Console.ReadLine();
                    if (newSurname == "-exit") return;
                }
                if (_marks.TryGetValue(newSurname, out mark))
                {
                    Console.WriteLine($"{newSurname}'s mark is {mark}");
                }
                else
                {
                    Console.WriteLine($"There is no student with {newSurname} surname.");
                }
            }
        }
    }
}