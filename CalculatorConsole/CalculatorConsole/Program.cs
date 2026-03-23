using CalculatorConsole;

Calculator calculator = new Calculator();

while (true)
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("Select an operation:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");

    double userInput = double.Parse(Console.ReadLine());

    if ((userInput == 5) || (userInput > 5) || (userInput <= 0))
    {
        Console.WriteLine("Exiting the calculator. Goodbye!");
        break;
    }

    Console.WriteLine("Enter the first number:");
    int Firstnum = int.Parse(Console.ReadLine());
    Console.WriteLine("enter the second number:");
    int Secondnum = int.Parse(Console.ReadLine());

    switch (userInput)
    {
        case 1:
            Console.WriteLine($"Result: {calculator.Addition(Firstnum, Secondnum)}");
            break;
        case 2:
            Console.WriteLine($"Result: {calculator.Subtraction(Firstnum, Secondnum)}");
            break;
        case 3:
            Console.WriteLine($"Result: {calculator.Multiplication(Firstnum, Secondnum)}");
            break;
        case 4:
            Console.WriteLine($"Result: {calculator.Division(Firstnum, Secondnum)}");
            break;
        default:
            Console.WriteLine("Invalid operation selected. Please try again.");
            break;
    }
}







