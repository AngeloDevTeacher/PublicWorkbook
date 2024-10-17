
// Variables

// This is the MAX SIZE
using System.ComponentModel;

/// <summary>
/// Purpose: Enter in up to  25 whole positive numbers, using 0 to end input. Display the number set, and the smallest and largest number.
/// Author: Angelo Encarnacion
/// Last Modified: 2024-10-17
/// </summary>
/// 
const int NumbersMaxSize = 25;
int[] numbers = new int[NumbersMaxSize];

// This is the LOGICAL SIZE
int countOfNumbersEntered = 0;

int smallestNumber = int.MaxValue; // https://stackoverflow.com/questions/21312081/how-to-represent-integer-infinity
int largestNumber = 0;

string userInput = "";
string output = "";
int numberEntered = 0;

// Program START
// Display purpose
Console.WriteLine("Largest and Smallest:");
Console.WriteLine("Enter in up to 25 positive whole numbers. Use 0 to stop entry.");
Console.WriteLine("The program will display the numbers, and the biggest and smallest.");
Console.WriteLine();
// do while
do
{
    // Prompt the user to enter a number
    // Validate and parse input
        // Try catch
        // Parse
    try
    {
        Console.Write("Please enter a positive whole number: ");
        userInput = Console.ReadLine();

        numberEntered = int.Parse(userInput);
        if (numberEntered < 0)
        {
            Console.WriteLine("Please enter a positive number.");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"{userInput} was not a valid number.");

    }
    
    if (numberEntered != 0)
    {
        // Comparisons for largest and smallest
        if (numberEntered < smallestNumber)
        {
            smallestNumber = numberEntered;
        } // EO if for smallest
        if (numberEntered > largestNumber)
        {
            largestNumber = numberEntered;
        } // EO if for largest
        // Update variables
        numbers[countOfNumbersEntered] = numberEntered;
        countOfNumbersEntered++;
    } // EO if for NOT zero

} while (numberEntered != 0 && countOfNumbersEntered < 25); // EO main do-while
// Display output

Console.WriteLine();
for (int i = 0; i < countOfNumbersEntered; i++) 
{
    output += $"{numbers[i]} ";
}

Console.WriteLine($"{output}");
Console.WriteLine($"The largest number is {largestNumber}.");
Console.WriteLine($"The smallest number is {smallestNumber}.");

// Program End