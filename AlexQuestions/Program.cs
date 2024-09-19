/// <summary>
/// Explore the variable and display questions.
/// Author: Angelo Encarnacion angeloe@nait.ca
/// Date Modified: 2024-09-19
/// </summary>
/// 


// Variables
int amountOfCookies;
double costPerCookie;

double totalCost;

string userInput = "";


// Main Program

// Display program purpose
Console.WriteLine("------ Cookie cost calculator ------");
Console.WriteLine();

// Prompt for amount of cookies
Console.Write("Enter a whole number for the amount of cookies:\t");
userInput = Console.ReadLine();
amountOfCookies = int.Parse(userInput);

// Prompt for cost per cookie
Console.Write("Enter in a cost per cookie:\t");
userInput = Console.ReadLine();
costPerCookie = double.Parse(userInput);

// DO MATH - calculate the totalCost
totalCost = amountOfCookies * costPerCookie;

// Display totalCost
Console.WriteLine(totalCost);