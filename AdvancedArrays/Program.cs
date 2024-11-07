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

string userInput = "";
int numberInput = 0;

do
{

} while (numberInput != EndInput && logicalSize < NumberArraySize);