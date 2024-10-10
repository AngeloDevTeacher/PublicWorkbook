/// <summary>
/// Purpose: Calculate the sum of squares from 1 to the inputted number.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-10-10 
/// </summary>

string userInput = "";
int mySquare = 0;
int outputSum = 0;

// Display purpose
Console.WriteLine("--------Square Sum---------");
Console.WriteLine("This program will sum up the squares from 1 to your inputted number.");
Console.WriteLine();

// Prompt User
Console.Write("Please enter in a positive integer:\t");
userInput = Console.ReadLine();
mySquare = int.Parse(userInput);

// Calculate
for (int i = 1; i <= mySquare; i++)
{
    outputSum += i * i;
}

// Display
Console.WriteLine();
Console.WriteLine($"The sum of the squares is {outputSum}");