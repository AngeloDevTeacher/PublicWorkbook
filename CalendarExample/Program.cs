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


static int PromptInt(string promptMessage)
{

}