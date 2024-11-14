// What is an array?
// An array is a data-structure (a "collection" of data)

// We use arrays to store similar types of data, and the elements of the array can be accessed by an index: it's position in the array.

// Arrays have:
// - A type (what the datatype of the array is determines what it holds)
// - a length (once set, cannot be changed)
// - elements, which hold data/values

// Logical size:
// - Not all arrays are filled completely with explicitly assigned values (many are set by default)
// - Tracking the logical size is useful for when we have only some of the array filled
// - This is done using an int.

// Parallel arrays hold data relating to eachother via the index contents matching.
const int MaxSize = 25;

int[] idNumbers = new int[MaxSize];
string[] userNames = new string[MaxSize];
int[,] twoDimentionalArray = new int[MaxSize,MaxSize];

// I can SET elements of the array to a value using the index:
idNumbers[1] = 32;
idNumbers[2] = 5 * 2;
idNumbers[3] = idNumbers[1] + idNumbers[2];

twoDimentionalArray[3, 4] = 12;

// I can read elements of an array using the index:
Console.WriteLine(idNumbers[1]);
int indexToRead = 3;
Console.WriteLine(indexToRead);

for (int idx = 0; idx < idNumbers.Length; idx++)
{
    idNumbers[idx] = idx * idx;
}
for (int idx = 0; idx < idNumbers.Length; idx++)
{
    Console.WriteLine(idNumbers[idx]);
}


static void SetElementToZero(int[] arrayToChange, int indexToChange)
{
    arrayToChange[indexToChange] = 0;
}


// When I pass in an array as a argument, it changes the original array.
// (Passed by reference)
SetElementToZero(idNumbers,5);

for (int idx = 0; idx < idNumbers.Length; idx++)
{
    Console.WriteLine(idNumbers[idx]);
}