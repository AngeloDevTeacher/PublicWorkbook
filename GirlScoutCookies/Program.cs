///<summary>
/// This program calculates the amount of money made from selling cookies.
/// Author: Angelo Encarncaion - angeloe@nait.ca
/// Date Modified: 2024-09-17
/// </summary>
/// 


/* 
 * A bag of cookies holds 26/10 cookies.
 * The calorie information on the bag claims that there are 10
servings in the bag and that each serving equals 175 calories.
Write a program that lets the user
enter the number of cookies he or she actually ate and then reports the number of total calories
consumed 
 */

int bagCapacity = 26;
int bagServingCount = 10;

// This will be 2.6f
float cookiesPerServing = (float)bagCapacity / (float)bagServingCount;
int caloriesPerServing = 175;

int cookiesEaten = 0;
float caloriesEaten = 0;


// Display Program intro
Console.WriteLine("--- Calorie intake calculator ---");
Console.WriteLine();

// Prompt for user to enter the amount of cookies:
Console.Write("Enter a whole number of cookie eaten: ");
cookiesEaten = int.Parse(Console.ReadLine());

caloriesEaten = (caloriesPerServing / cookiesPerServing) * cookiesEaten;

Console.WriteLine("You have eaten " + caloriesEaten + " calories");
Console.ReadLine();