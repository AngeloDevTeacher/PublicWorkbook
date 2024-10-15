/// <summary>
/// Array Problems 1
/// Author: Angelo Encarnacion
/// Date Modified: 2024-10-15
/// </summary>



// Create a program that will allow the user to enter up to 25 numbers into an array. Calculate and display the mean average of the numbers.


// Variables
string userInput = "";
const int MeanAverageMaxLength = 25;
double outputSum = 0;
double meanAverage = 0;
int currentNumberCount = 0;

double[] numbers = new double[MeanAverageMaxLength];

// Program Purpose:
Console.WriteLine("Mean Average Calc");
Console.WriteLine();

do
{
    Console.WriteLine("Enter a number, or hit enter to stop.");
    Console.Write("Please enter a number:\t");
    userInput = Console.ReadLine();
    if (userInput != string.Empty)
    {
        try
        {
            numbers[currentNumberCount] = double.Parse(userInput);
            currentNumberCount++;
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter in a valid number.");
        }
    }


} while (userInput != string.Empty && currentNumberCount < MeanAverageMaxLength);

for (int i = 0; i < currentNumberCount; i++)
{
    outputSum += numbers[i];
}
meanAverage = outputSum / currentNumberCount;
Console.WriteLine($"The sum of the {currentNumberCount} number is {meanAverage}.");