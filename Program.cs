using System;

class Program
{
  static void Main()
  {
    int valueA, exponentValue, powerResult, inputValue, secondDigit, firstDigit, remainingPart, modifiedNumber, finalAnswer, temporary, numberOfDigits ;

    Console.WriteLine("Task 1 \nEnter A: ");
        
    valueA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter N: ");
    exponentValue = Convert.ToInt32(Console.ReadLine());

    powerResult = 1;

    for (int LoopCounter = 0; LoopCounter < exponentValue; ++LoopCounter) powerResult *= valueA;
    Console.WriteLine($"{valueA}^{exponentValue} = {powerResult}");

    Console.WriteLine("\nTask 2 \nEnter x (>=100): ");
    inputValue = Convert.ToInt32(Console.ReadLine());

    temporary = inputValue;
    numberOfDigits = 0;

    while (temporary > 0)
    {
        temporary /= 10; ++numberOfDigits;
    }
       
    secondDigit = (inputValue / (int)Math.Pow(10, numberOfDigits - 2)) % 10;
    firstDigit = inputValue / (int)Math.Pow(10, numberOfDigits - 1);
    remainingPart = inputValue % (int)Math.Pow(10, numberOfDigits - 2);
    modifiedNumber = firstDigit * (int)Math.Pow(10, numberOfDigits - 2) + remainingPart;
    finalAnswer = modifiedNumber * 10 + secondDigit;

    Console.WriteLine($"x = {inputValue}\nResult n = {finalAnswer}");
  }
}