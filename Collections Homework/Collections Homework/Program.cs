namespace Collections_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1,2, or 3 to check task 1,2, or 3:");
                var choice = Console.ReadLine();
                while (string.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("Invalid input. Please select 1,2, or 3.");
                    choice = Console.ReadLine();
                }
                int.TryParse(choice, out int task);
                switch (task)
                {
                    case 1:
                        CheckTaskFirst();
                        break;
                    case 2:
                        CheckTaskSecond();
                        break;
                    case 3:
                        CheckTaskThird();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
        private static void CheckTaskFirst()
        {
            var taskOne = new TaskOne();
            taskOne.TaskLoop();
        }
        private static void CheckTaskSecond()
        {
            var taskTwo = new TaskTwo();
            taskTwo.TaskLoop();
        }
        private static void CheckTaskThird ()
        {
            var taskThree = new TaskThree();
            taskThree.TaskLoop();
        }
    }
}