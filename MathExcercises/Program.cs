/// <summary>
/// Write a program that will prompt the user for three real numbers and computes their mean average.Display the average to the user.
/// Name: Angelo Encarnacion angeloe@nait.ca    
/// Date Modified: 2024-09-19
/// </summary>
/// 


// Variables
int number1 = 0;
int number2 = 0;
int number3 = 0;

int outputNumber = 0;

// Main Program

// Display program purpose
Console.WriteLine("Mean Average Calculator");
// Prompt
Console.Write("Enter in the first whole real number:\t");
number1 = int.Parse(Console.ReadLine());

Console.Write("Enter in the second whole real number:\t");
number2 = int.Parse(Console.ReadLine());

Console.Write("Enter in the third whole real number:\t");
number3 = int.Parse(Console.ReadLine());

// Calculate
outputNumber = (number1 + number2 + number3) / 3;
// Output display
Console.WriteLine("The average of the numbers is: " + outputNumber);