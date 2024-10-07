/*
 * 
 * Write a program lets the user guess whether the flip of a coin results in heads or tails. The program
randomly generates an integer 0 to 1, which represents head or tail. The program prompts the user to enter
a guess, and reports whether the guess is correct or incorrect.
*/
string userInput = "";
int randomFlip;

// Make a new instance of random
Random randomInstance = new Random();
// Set the randomFlip value to a generated result from the randomInstance.
randomFlip = randomInstance.Next(0, 2);

// Prompt the user to make a guess:
Console.Write("Please choose [0] for heads and [1] for tails:\t");
userInput = Console.ReadLine();

// Compare the flip to the user guess:
if (int.Parse(userInput) == randomFlip)
{
    Console.WriteLine("You got it right!");
}
else
{
    Console.WriteLine($"You got it wrong! The coin was a {randomFlip}");
}