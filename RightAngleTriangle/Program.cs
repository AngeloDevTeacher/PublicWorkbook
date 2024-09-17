/// <summary>
/// Write a program that solves for the hypotenuse given the height and width of a right angle triangle.
/// Author: Angelo Encarnacion - angeloe@nait.ca
/// Date Modified: 2024-09-17
/// </summary>
/// 

// Variables
double width = 0;
double height = 0;


double hypotenuse = 0;

// Display Program Purpose
Console.WriteLine("===== Hypotenuse Calculator =====");
Console.WriteLine();

// Prompt for our variables:
Console.Write("Enter the width of the triangle: ");
width = double.Parse(Console.ReadLine());

Console.Write("Enter the height of the triangle: ");
height = double.Parse(Console.ReadLine());

// Set the value of the hypotenuse to the formula.
hypotenuse = Math.Sqrt( Math.Pow(width, 2) + Math.Pow(height, 2) );

// Output the result. If I round in the output I keep the accurate value in memory in case I have logic later.
Console.WriteLine();
Console.WriteLine($"The hypotenuse is {Math.Round(hypotenuse, 5)}");
Console.WriteLine("END OF PROGRAM");