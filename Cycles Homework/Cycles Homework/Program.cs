//Task 1

int j = 0;
int i = 1;
int n = 0;

for (int amount = 0; amount < 10; amount++)
{
    Console.Write($"{j} ");
    n = j + i;
    j = i;
    i = n;
}

Console.WriteLine("\n");

//Task 2

for (int number = 2; number <= 20; number+=2)
{
    Console.Write($"{number} ");
}

Console.WriteLine("\n");

//Task 3

for (int a = 1; a <=5; a++)
{
    for (int b = 1; b <= 9; b++)
    {
        Console.Write($"{a}*{b}={a * b}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");

//Task 4

string password = "qwerty";
string? userInput;

do
{
    Console.Write("Enter your password:");
    userInput = Console.ReadLine();
    if (userInput != password)
    {
        Console.WriteLine("Wrong password! Try again!");
    }
}
while (userInput != password);

Console.WriteLine("Correct Password!");