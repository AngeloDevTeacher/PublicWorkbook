/// <summary>
/// Create a program that takes in positive numbers into an array, and returns the average.
/// Use a sentinel variable to control when to end the input.
/// 
/// Author: Angelo Encarnacion
/// Date Modified: 2024-11-07
/// </summary>
/// 

// What is a sentinel variable? 
// A sentinel is a variable we use to control flow, for example in loops.
// It's gerenally a value used like a dummy value, and will end a loop.
// Sentinels are primarily used in while loops (which are NOT counter controlled). 

const int EndInput = -1;
const int NumberArraySize = 100;

int[] numbers = new int[NumberArraySize];
int logicalSize = 0;


int numberInput = 0;

do
{
	numberInput = PromptInt("Please enter a whole positive number, use -1 to stop:\t");
	if(numberInput == EndInput)
	{
        Console.WriteLine("Stopping input");
    }
	else if (numberInput < 0)
	{
        Console.WriteLine("Please enter a positive number");
    }
	else
	{
		numbers[logicalSize] = numberInput;
		logicalSize++;
	}
} while (numberInput != EndInput && logicalSize < NumberArraySize);

Console.WriteLine( AverageNumber(numbers, logicalSize) );

Console.WriteLine( LowestValue(numbers, logicalSize) );



/// <summary>
/// Prompt the user using message, <see langword="return"/> their input if it's an int.
/// </summary>
static int PromptInt(string message)
{
	int output = 0;
	bool isValid = false;
	do
	{
		try
		{
			Console.Write(message);
			output = int.Parse(Console.ReadLine());
			isValid = true;
		}
		catch (Exception)
		{
            Console.WriteLine("Error: Please enter a whole number.");
        }
	} while (!isValid);
	return output;
}

/// <summary>
/// Calculate the average of the inputted numbers in an array.
/// </summary>
static double AverageNumber(int[] numbers, int logicalSize)
{
	double output = 0;
    for (int i = 0; i < logicalSize; i++)
    {
        output += numbers[i];
    }
	output /= logicalSize;
    return output;
}
/// <summary>
/// Find the lowest number inputted numbers in an array.
/// </summary>
static int LowestValue(int[] nums, int count)
{
	int output = 0;
	if (count > 0){
        output = nums[0];
		for (int i = 1; i < count; i++) 
		{
			if (nums[i] < output)
			{
				output = nums[i];
			}
		}
    }
	return output;
}