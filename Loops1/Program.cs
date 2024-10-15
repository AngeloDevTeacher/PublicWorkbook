/// <summary>
/// Purpose: Calculate the sum of squares from 1 to the inputted number.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-10-10 
/// </summary>

//string userInput = "";
//int mySquare = 0;
//int outputSum = 0;

//// Display purpose
//Console.WriteLine("--------Square Sum---------");
//Console.WriteLine("This program will sum up the squares from 1 to your inputted number.");
//Console.WriteLine();

//// Prompt User
//Console.Write("Please enter in a positive integer:\t");
//userInput = Console.ReadLine();
//mySquare = int.Parse(userInput);

//// Calculate
//for (int i = 1; i <= mySquare; i++)
//{
//    outputSum += i * i;
//}

//// Display
//Console.WriteLine();
//Console.WriteLine($"The sum of the squares is {outputSum}");


// Question 2:

/// <summary>
/// Add up inputted ages and output average.
/// Author: Angelo Encarnacion
/// Date modified: 2024-10-10
/// </summary>

// Variables
// Total sum of age.
int ageSum = 0;
// Number of entries to be used in the average.
int numberOfEntries = 0; 
// The user input as a string.
string ageInput = "";
// The parsed value of the user input.
int ageNumber = 0;

double averageAgeOutput = 0;

// Program Start: 

// List program purpose and instructions.
// Collect the ages using a loop structure
// -> Prompt the user to input an age
// -> Validate the input, and assign it to ageNumber if valid
// -> add ageNumber to the sum.
// -> During collection, validate the values via conditions and error handling
// Calculate the final average
// Display the average

// LIST PURPOSE:
Console.WriteLine("**** Age average caluclator ****");
Console.WriteLine("This program will allow you to enter ages, and then average them when you are done.");

// COLLECT AGES.
do
{
	// PROMPT USER
	try
	{
        Console.Write("Please enter an age:\t");
        ageInput = Console.ReadLine();

        ageNumber = int.Parse(ageInput);

		if (ageNumber > 0)
		{
			ageSum += ageNumber;
			numberOfEntries++;
		}
		else if (ageNumber == 0)
		{
			averageAgeOutput = (double)ageSum / (double)numberOfEntries;
			if (numberOfEntries == 0)
			{
				Console.WriteLine("You did not enter in any ages.");
				averageAgeOutput = 0;
			}
		}
		else
		{
			Console.WriteLine("Please enter a valid age");
			if (ageNumber < 0)
			{
				Console.WriteLine($"The {ageNumber} number is negative, and is not valid.");
			}
			else if (ageNumber > 999)
			{
                Console.WriteLine($"The {ageNumber} number is not realistic, and is not valid.");
            }
		}
    }
	catch (Exception e)
	{
		Console.WriteLine("Please enter a whole number for the age.");
		//throw; <- This is what crashes your programs.
	}


} while (ageNumber != 0);

Console.WriteLine($"The average age is {averageAgeOutput}");
