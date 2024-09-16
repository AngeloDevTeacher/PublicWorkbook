
// Variables
using System.Diagnostics.Metrics;

/// <summary>
/// Write a C# console application that will calculate and display the area of a rectangle using the length and breadth that are input at the console by the user.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-09-16
/// </summary>

// Variables
// I'm declaring length and width - they are grouped logically.
float length;
float width;
// I've seperated area, because it is an OUTPUT variable.
// Use your own judgement!
float area;


// This is describing the program. Most of our assignments will do something like this.
Console.WriteLine("---- Rectangle Area Calculator ----");
Console.WriteLine();


// This is the first prompt. We use Console.Write instead of Console.WiteLine BECAUSE we want the typing to happen on the same line as the prompt.
Console.Write("Enter the length of the rectangle: ");
length = float.Parse(Console.ReadLine());

Console.Write("Enter the breadth of the rectangle: ");
width = float.Parse(Console.ReadLine());

// I can set a variable to be equal to a result!
area = length * width;

// This is basic concatination. We can "add" things to strings, whether numbers or other strings.
Console.WriteLine("The area of the rectangle is " + area);
Console.WriteLine("End of Program.");
