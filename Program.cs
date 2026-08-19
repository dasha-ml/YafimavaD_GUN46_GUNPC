Console.Write("Please enter a number: ");
if (!Int32.TryParse(Console.ReadLine(), out var firstNumber))
{
    Console.WriteLine("Wrong input!");
    return;
}

Console.Write("Please enter another number: ");
if (!Int32.TryParse(Console.ReadLine(), out var secondNumber))
{
    Console.WriteLine("Wrong input!");
    return;
};

Console.Write("Please select an operation: &, |, or ^.");
if ((!Char.TryParse(Console.ReadLine(), out var operation)) || ((operation!='&') && (operation!='|') && (operation!='^')))
{
    Console.WriteLine("You selected invalid operation!");
    return;
};

switch (operation)
{
    case '&':
        Console.WriteLine("Result of & operation in binary system = " + Convert.ToString(firstNumber & secondNumber,2));
        Console.WriteLine("Result of & operation in decimal system = " + Convert.ToString(firstNumber & secondNumber, 10));
        Console.WriteLine("Result of & operation in hexadecimal system = " + Convert.ToString(firstNumber & secondNumber, 16));
        break;
    
    case '|':
        Console.WriteLine("Result of | operation in binary system = " + Convert.ToString(firstNumber | secondNumber, 2));
        Console.WriteLine("Result of | operation in decimal system = " + Convert.ToString(firstNumber | secondNumber, 10));
        Console.WriteLine("Result of | operation in hexadecimal system = " + Convert.ToString(firstNumber | secondNumber, 16));
        break;

    case '^':
        Console.WriteLine("Result of ^ operation in binary system = " + Convert.ToString(firstNumber ^ secondNumber, 2));
        Console.WriteLine("Result of ^ operation in decimal system = " + Convert.ToString(firstNumber ^ secondNumber, 10));
        Console.WriteLine("Result of ^ operation in hexadecimal system = " + Convert.ToString(firstNumber ^ secondNumber, 16));
        break;
}