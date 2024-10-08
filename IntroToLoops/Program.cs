﻿/// <summary>
/// Purpose: learning pre-condition loops
/// Author: Angelo Encarnacion - angeloe@nait.ca
/// Date Modified: 2024-10-8
/// </summary>


// A LOOP is a control structure where we REPEAT instructions.
// When we say it is a control structure, we can control WHEN the loop repeats.

//int counter = 1;
//// The while loop repeats the body code so long as the condition above is true.
//while (counter <= 10)
//{
//    Console.WriteLine(counter);
//    counter += 2;
//}
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