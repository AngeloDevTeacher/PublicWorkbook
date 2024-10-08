/// <summary>
/// Purpose: learning pre-condition and post-condition loops
/// Author: Angelo Encarnacion - angeloe@nait.ca
/// Date Modified: 2024-10-8
/// </summary>


// A LOOP is a control structure where we REPEAT instructions.
// When we say it is a control structure, we can control WHEN the loop repeats.

int counter = 1;
// The while loop repeats the body code so long as the condition above is true.
while (counter <= 10)
{
    Console.WriteLine(counter);
    counter += 2;
}
// The loop above is a pre-condition loop.
// It means it will NOT run if the condition is false when the loop is first read.
// You can test by making counter 11 on line 11.


int catCounter = 1;
// The do-while loop is a post-condition loop.
do
{
    Console.WriteLine(catCounter);
    catCounter += 2;
} while (catCounter < 10);
// A POST-CONDITION LOOP will always run the body (if it is read) FIRST.
// After it runs it once, it will then do a check for all subsequent runs.


// A for loop is a pre-condition style loop.
// It's best for counting things in it's condition.
// Standard use of the for loop includes some specific things.
// It's the only place in CPSC1012 that we will accept a single letter variable name.

// Firstly, the for loop ususally initalizes a local variable that can only be used in it scope (its own body.)
// Next, we have the end condtion for the for loop. We don't want to clutter this end condition, as the structure of the for loop is good for certains things.
// Lastly, we have our increment (or decrement) that will trigger every loop.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


// There is one more type of loop we will cover in this course: we use it OVER a collection.
// This is called the foreach loop (it's the for loop in python)

// This has a lot less up-front control, and is usually used to ease development.
// It uses a for loop in the background - usually, please consider using a for loop instead.
string name = "Angelo Encarnacion";
foreach (var letter in name)
{
    Console.WriteLine(letter);
}

// The exact equivalent in for loop:
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}