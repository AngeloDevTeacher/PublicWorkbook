/// <summary>
/// Purpose: To generally caluculate a pet's cost of living by pet and number of months.
/// Author: Angelo Encarnacion angeloe@nait.ca
/// Date Modified: 2024-10-24
/// </summary>
/// 

// General Plan :
// ✔️Calculate random
// ✔️Init variables
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
        }
    }
    catch (Exception)
    {
        Console.WriteLine("ERROR: Please enter a valid option.");
    }


} while (!validInput);
validInput = false;
// Months with pet
do
{

} while (!validInput);
// End Program