/// <summary>
/// Purpose: To generally caluculate a pet's cost of living by pet and number of months.
/// Author: Angelo Encarnacion angeloe@nait.ca
/// Date Modified: 2024-10-24
/// </summary>
/// 

// General Plan :
// Calculate random
// Init variables
// Loop-Prompt the user, until I get valid answers
// Calc:
// - License costs PER FULL YEAR
// - Misc cost per month
// - Food Costs per MONTH

// Display results
// Use alignment formatting!
// Ensure using currency format.



// Variables
int amountOfMonths = 0;
string typeOfPet = ""; // My only valid answers will be "c" or "d".

Random randomInstance = new Random();
double addtionalCostPerMonth = randomInstance.Next(3000, 5001)/100.00; // Lets say I had to calculate between $30 and 50
//Console.WriteLine( $"{addtionalCostPerMonth:c}"); // Currency format!

const double CatLicenseCost = 20.00;
const double DogLicenseCost = 120.00;

const double FoodRateUnderTwoYears = 500.00;
const double FoodRateFromTwoYearsToEight = 900.00;
const double FoodRateFromEightYearsToTwelve = 1200.00;
const double FoodRatePerMonthAdditional = 20.00;
// Main Program

// End Program