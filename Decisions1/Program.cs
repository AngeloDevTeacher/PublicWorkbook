/*
 * 
 * Write a program lets the user guess whether the flip of a coin results in heads or tails. The program
randomly generates an integer 0 to 1, which represents head or tail. The program prompts the user to enter
a guess, and reports whether the guess is correct or incorrect.
*/
//string userInput = "";
//int randomFlip;

//// Make a new instance of random
//Random randomInstance = new Random();
//// Set the randomFlip value to a generated result from the randomInstance.
//randomFlip = randomInstance.Next(0, 2);

//// Prompt the user to make a guess:
//Console.Write("Please choose [0] for heads and [1] for tails:\t");
//userInput = Console.ReadLine();

//// Compare the flip to the user guess:
//if (int.Parse(userInput) == randomFlip)
//{
//    Console.WriteLine("You got it right!");
//}
//else
//{
//    Console.WriteLine($"You got it wrong! The coin was a {randomFlip}");
//}


// Question 2 - leap years
// d by 4 but not by 100 or d by 400

//string userInput;
//int year;


//// Describe purpose
//Console.WriteLine("This program will tell you if an inputted year is a leap year");
//Console.WriteLine();

//// Prompt user for year:
//Console.Write("Please enter a year:\t");
//userInput = Console.ReadLine();

//// Leap years for the if statement because it's not the "default case".
//year = int.Parse(userInput);
//if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 )
//{
//    Console.WriteLine($"{year} is a leap year!");
//}
//else
//{
//    Console.WriteLine($"{year} is NOT a leap year!");
//}

//Console.ReadLine();


string userInput = "";
int userChoice;

Random randomInstance = new Random();
int randomChoice = randomInstance.Next(0,4);

Console.Write("Please choose scissors[0], rock[1], or paper[2]\t");
userInput = Console.ReadLine();
userChoice = int.Parse(userInput);

if (userChoice == randomChoice)
{
    Console.WriteLine("It's a draw");
}//
// ROCK
else if (userChoice == 1)
{ 
    // AI scissors
    if(randomChoice == 0)
    {
        Console.WriteLine("AI chose scissors, you win!");
    }
    // AI paper
    else if (randomChoice == 2)
    {
        Console.WriteLine("AI chose paper, you lose!");
    }
}

// PAPER
else if (userChoice == 2)
{
    // AI scissors
    if (randomChoice == 0)
    {
        Console.WriteLine("AI chose scissors, you lose!");
    }
    // AI paper
    else if (randomChoice == 1)
    {
        Console.WriteLine("AI chose rock, you win!");
    }
}