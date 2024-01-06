Console.WriteLine("Enter a number: ");

string firstUserInput = Console.ReadLine();

Console.WriteLine("\nEnter a second number: ");

string secondUserInput = Console.ReadLine();

if (int.TryParse(firstUserInput, out int firstNumberConvertedToInt) && int.TryParse(secondUserInput, out int secondNumberConvertedToInt))
{
    Console.WriteLine("--- Results ---");
    Console.WriteLine($"Add: {firstNumberConvertedToInt} + {secondNumberConvertedToInt} = " + (firstNumberConvertedToInt + secondNumberConvertedToInt));
    Console.WriteLine($"Subtract: {firstNumberConvertedToInt} - {secondNumberConvertedToInt} = " + (firstNumberConvertedToInt - secondNumberConvertedToInt));
    Console.WriteLine($"Multiply: {firstNumberConvertedToInt} * {secondNumberConvertedToInt} = " + (firstNumberConvertedToInt * secondNumberConvertedToInt));

    if (secondNumberConvertedToInt == 0)
    {
        Console.WriteLine("Division by 0 is invalid");
    }
    else
    {
        double divisionResult = (double) firstNumberConvertedToInt / (double) secondNumberConvertedToInt;
        Console.WriteLine($"Division: {firstNumberConvertedToInt} / {secondNumberConvertedToInt} = " + divisionResult);
    }
}
else
{
    Console.WriteLine("Invalid input");
}
