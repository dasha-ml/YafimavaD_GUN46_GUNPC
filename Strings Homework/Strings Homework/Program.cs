using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Strings_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Enter your favorite fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter your favorite vegetable:");
            string vegetable = Console.ReadLine();
            string concatenate = ConcatenateStrings(fruit, vegetable);
            Console.WriteLine (concatenate);

            Console.WriteLine();

            //Task 2
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            int ageAsNumber;
            string? userAge;
            do
            {
                Console.WriteLine("Enter your age:");
                userAge = Console.ReadLine();
                if (!int.TryParse(userAge, out ageAsNumber))
                {
                    Console.WriteLine("Incorrect input.");
                }
            }
            while (!int.TryParse(userAge, out ageAsNumber));
            
            string greeting = GreetUser(userName, ageAsNumber);
            Console.WriteLine(greeting);

            Console.WriteLine();

            //Task 3
            Console.WriteLine("Enter a name of the current month:");
            string currentMonth = Console.ReadLine();
            string stringInfo = StringInformation (currentMonth);
            Console.WriteLine(stringInfo);

            Console.WriteLine();

            //Task 4
            Console.WriteLine("Enter a name of a car:");
            string car = Console.ReadLine();
            string carSymbols = FiveSymbols(car);
            Console.WriteLine(carSymbols);

            Console.WriteLine();

            //Task 5
            string[] drinks = { "Pepsi", "Fanta", "Sprite", "7Up", "Mirinda" };
            string oneString = ArrayAndString(drinks);
            Console.WriteLine(oneString);

            Console.WriteLine();

            //Task 6
            string myFood = "My favorite food is pizza with pineapples and pizza with mashrooms.";
            string dishOne = "Pizza";
            string dishTwo = "Pasta";
            string favoriteFood = WordsReplacement(myFood, dishOne, dishTwo);
            Console.WriteLine(favoriteFood);

        }
        public static string ConcatenateStrings(string firstWord, string secondWord)
        {
            return $"Your favorite fruit is {firstWord}. Your favorite vegetable is {secondWord}.";
        }

        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }

        public static string StringInformation (string text)
        {
            int symbols = text.Length;
            string upperCase = text.ToUpper();
            string lowerCase = text.ToLower();
            return $"\"{text}\" has {symbols} symbols.\n\"{text}\" in Upper Case looks like {upperCase}.\n\"{text}\" in Lower Case looks like {lowerCase}.";
        }

        public static string FiveSymbols (string input)
        {
            if (input.Length >= 5)
            {
                string fiveSymbols = input.Substring(0, 5);
                return $"First 5 symbols of \"{input}\" is {fiveSymbols}.";
            }
            else
            {
                return "Invalid input. Your entered name has fewer than 5 symbols, so the task can't be completed.";
            }
        }

        public static string ArrayAndString(string[] sodas)
        {
            StringBuilder sodaList = new StringBuilder();
            foreach (string soda in sodas)
            {
                sodaList.Append(soda);
                sodaList.Append(" ");
            }

            return sodaList.ToString().TrimEnd();
        }

        public static string WordsReplacement (string wholeLine, string wordToReplace, string replacementWord)
        {
            string replacementResult = wholeLine.Replace(wordToReplace, replacementWord, StringComparison.OrdinalIgnoreCase);
            return replacementResult;
        }
    }   
}
