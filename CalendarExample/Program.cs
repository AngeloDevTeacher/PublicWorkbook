/// <summary>
/// Create a calendar display that takes a number of months and a starting day of week:
/// Author: Angelo Encarnacion
/// Date Modified: 2024-11-05
/// </summary>
/// 


// UserInput
int day = 0;
int endDate = 31;
string userInput = "";

userInput = Prompt("Enter the day of week start:\t");
userInput = userInput.ToLower().Substring(0, 3);
//endDate = PromptInt("Enter a number of days\t");



// How do I know the number of days given a month and year?
string month = Prompt("Enter month:\t").ToLower().Substring(0,3);
int year = PromptInt("Enter the year:\t");
switch (month)
{
    case "feb":
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            endDate = 29;
        }
        else
        {
            endDate = 28;
        }
        break;
    case "jan":
    case "mar":
    case "may":
    case "jul":
    case "aug":
    case "oct":
    case "dec":
        endDate = 31;
        break;
    case "apr":
    case "jun":
    case "sep":
    case "nov":
        endDate = 30;
        break;
    default:
        endDate = 31;
        break;
}


DisplayCalendar(endDate, userInput);

/// <summary>
/// Displays a calendar with starting on a specific day and having a specific number of days.
/// </summary>
static void DisplayCalendar(int numberofDays, string dayStart)
{
    const int Height = 5;
    const int Width = 7;

    int day = 0;
    int endDate = numberofDays;


    switch (dayStart)
    {
        case "sun":
            day = 1;
            break;
        case "mon":
            day = 0;
            break;
        case "tue":
            day = -1;
            break;
        case "wed":
            day = -2;
            break;
        case "thu":
            day = -3;
            break;
        case "fri":
            day = -4;
            break;
        case "sat":
            day = -5;
            break;
        default:
            break;
    }

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

/// <summary>
/// Prompts the user for a string using the message.
/// </summary>
static string Prompt(string promptMessage)
{
    Console.Write(promptMessage);
    return Console.ReadLine();
}