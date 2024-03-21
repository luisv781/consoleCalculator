// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type a number");
double numberOne = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("You have chosen {0}. Choose an operator.(A/S/M/D)");

string oprtr = Console.ReadLine().ToLower();
switch(oprtr)
{
    case "a":
        oprtr = "add";
        break;
    case "s":
        oprtr = "subtract";
        break;
    case "m":
        oprtr = "multiply";
        break;
    case "d":
        oprtr = "divide";
        break;
    default:
        Console.WriteLine(oprtr + " is an unvalid operator.");
        Environment.Exit(0);
        break;
}
Console.WriteLine("You have chosen to {0}. Now choose a second number.", oprtr);
double numberTwo = Convert.ToDouble(Console.ReadLine());
double result = 0;
switch (oprtr)
{
    case "add":
        result = numberOne + numberTwo;
        break;
    case "subtract":
        result = numberOne - numberTwo;
        break;
    case "multiply":
        result = numberOne * numberTwo;
        break;
    case "divide":
        result = numberOne / numberTwo;
        break;
    default:
        Console.WriteLine("Error operating on numbers.");
        Environment.Exit(0);
        break;
}
Console.WriteLine("Result: {0}.", result);