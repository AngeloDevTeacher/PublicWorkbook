/// <summary>
/// Purpose: To generally caluculate a pet's cost of living by pet and number of months.
/// Author: Angelo Encarnacion angeloe@nait.ca
/// Date Modified: 2024-10-24
/// </summary>
/// 

// General Plan :
// ✔️Calculate random
// ✔️Init variables
// ✔️Loop-Prompt the user, until I get valid answers
// Calc:
// - License costs PER FULL YEAR
// - Misc cost per month
// - Food Costs per MONTH

// Display results
// Use alignment formatting!
// Ensure using currency format.



// Variables
int amountOfMonths = 0;
string userInput = "";
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

bool validInput = false;

double foodCostTotal = 0;
double petLicenseTotal = 0;
double miscCostTotal = 0;

// Main Program
// Program purpose
Console.WriteLine("==== Pet Calc ====");
// Pet type
do
{
    try
    {
        // Prompt Pattern:
        Console.Write("Please enter in [C] for cat, or [D] for dog:\t");
        userInput = Console.ReadLine(); // Save in user input so I can process cleanly.
        if (userInput.ToUpper()[0] == 'C' || userInput.ToUpper()[0] == 'D')
        {
            typeOfPet = userInput.ToUpper()[0].ToString();
            validInput = true;
        }
        else
        {
            Console.WriteLine("You entered something that was not \"C\" or \"D\".");
            validInput = false;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("ERROR: Please enter a valid option.");
        validInput = false;
    }
} while (!validInput);

validInput = false;
// Months with pet
do
{
    try
    {
        Console.Write("Please enter in a number of months:\t");
        userInput = Console.ReadLine(); 

        amountOfMonths = int.Parse(userInput);

        // What do we need to process?
        // negative numbers!
        if (amountOfMonths < 0)
        {
            Console.WriteLine("USER ERROR: Please enter a positive number of months.");
            validInput = false;
        }
        else
        {
            validInput = true;
        }
    }
    catch (Exception)
    {
        // I will catch:
        // Strings (invalid)
        // blank spaces
        // decimals
        Console.WriteLine("You didn't enter in a positive whole number for months!");
        validInput = false;
    }
} while (!validInput);

// Calculate
// License Cost
switch (typeOfPet)
{
    case "C":
        petLicenseTotal = CatLicenseCost + ((amountOfMonths / 12) * CatLicenseCost);
        break;
    case "D":
        petLicenseTotal = DogLicenseCost + ((amountOfMonths / 12) * DogLicenseCost);
        break;
    default:
        break;
}
//Console.WriteLine($"{petLicenseTotal:c}");


// misc cost
miscCostTotal = addtionalCostPerMonth * amountOfMonths;
//Console.WriteLine($"{miscCostTotal:c}");

if (amountOfMonths < 24)
{
    foodCostTotal = FoodRateUnderTwoYears;
}
else if (amountOfMonths >= 24 && amountOfMonths <= 96)
{
    foodCostTotal = FoodRateFromTwoYearsToEight;
}
else if (amountOfMonths >= 97 && amountOfMonths <= 144)
{
    foodCostTotal = FoodRateFromEightYearsToTwelve;
}
else // amountOfMonths > 144
{
    foodCostTotal = FoodRateFromEightYearsToTwelve + (FoodRatePerMonthAdditional * amountOfMonths);
}

// Display totals:
Console.WriteLine();

switch (typeOfPet)
{
    case "C":
        Console.WriteLine($"Pet License Cost: {CatLicenseCost:c} + {amountOfMonths / 12} * {CatLicenseCost}");
        break;
    case "D":
        Console.WriteLine($"Pet License Cost: {DogLicenseCost:c} + {amountOfMonths / 12} * {DogLicenseCost}");
        break;
    default:
        break;
}
Console.WriteLine("--------------------------");
Console.WriteLine($"{"Pet License",-18}{petLicenseTotal,8:$##0.00}");
Console.WriteLine($"{"Misc Cost",-18}{miscCostTotal,8:$##0.00}");
Console.WriteLine($"{"Food Cost",-18}{foodCostTotal,8:$##0.00}");

// End Program