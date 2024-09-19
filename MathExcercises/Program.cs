/// <summary>
/// Write a program that will prompt the user for three real numbers and computes their mean average.Display the average to the user.
/// Name: Angelo Encarnacion angeloe@nait.ca    
/// Date Modified: 2024-09-19
/// </summary>
/// 


// Variables
double number1 = 0;
double number2 = 0;
double number3 = 0;

double outputNumber = 0;

// Main Program

// Display program purpose
Console.WriteLine("Mean Average Calculator");
// Prompt
Console.Write("Enter in the first whole real number:\t");
number1 = double.Parse(Console.ReadLine());

Console.Write("Enter in the second whole real number:\t");
number2 = double.Parse(Console.ReadLine());

Console.Write("Enter in the third whole real number:\t");
number3 = double.Parse(Console.ReadLine());

// Calculate
outputNumber = (number1 + number2 + number3) / 3;
// Output display
Console.WriteLine($"The average of the numbers is: {outputNumber:#,##0.00}");

/// <summary>
/// Create a program that will sum the digits of a 3 digit number.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-09-19
/// </summary>

int numberInput = 0;

int hundredsNumber = 0;
int tensNumber = 0;
int onesNumber = 0;

int sum = 0;

// Dipsplay Purpose

// Prompt Input
Console.Write("Enter a 3 digit whole number:\t");
numberInput = int.Parse(Console.ReadLine());

// Divide by place
hundredsNumber = numberInput / 100;
tensNumber = (numberInput - (hundredsNumber * 100)) / 10;
onesNumber = (numberInput - ((hundredsNumber * 100) + (tensNumber * 10)));
// Add places
sum = hundredsNumber + tensNumber + onesNumber;
// Output
Console.WriteLine($"{numberInput} -> {sum}");
