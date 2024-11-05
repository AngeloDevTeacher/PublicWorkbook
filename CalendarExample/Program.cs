/// <summary>
/// Create a calendar display that takes a number of months and a starting day of week:
/// Author: Angelo Encarnacion
/// Date Modified: 2024-11-05
/// </summary>
/// 


// Do I know how to make a grid?

const int Height = 5;
const int Width = 7;

// UserInput
int day = 0;
int endDate = 31;
string userInput = "";

userInput = Prompt("Enter the day of week start:\t");
endDate = PromptInt("Enter a number of days\t");

Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
for (int h = 0; h < Height; h++)
{
    for (int w = 0; w < Width; w++)
    {
        if (day < 1 || day > endDate)
        {
            Console.Write(" \t");
        }
        else
        {
            Console.Write($"{day}\t");
        }
        day++;
    }
    Console.WriteLine();
}

/// <summary>
/// Continuously prompts the user for a int value until a valid int is provided.
/// </summary>
static int PromptInt(string promptMessage)
{
    int output = 0;
    bool isOutputValid = false;

    do
    {
        try
        {
            Console.Write(promptMessage);
            output = int.Parse(Console.ReadLine());
            isOutputValid = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("The input was not a number");
        }
    } while (!isOutputValid);

    return output;
}

static string Prompt(string promptMessage)
{
    Console.Write(promptMessage);
    return Console.ReadLine();
}