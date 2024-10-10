/// < summary>
/// Purpose: Demonstrate simple error handling and notes re: class expectations.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-10-10
/// </summary>
/// 


// What is error handling?
// Sometimes, things go wrong! NORMALLY, this is because of our correct code being used improperly.
// We need to handle errors correctly - so we don't "crash" if we can avoid crashing.

// What is a common error?
// Putting in the wrong data type into the program.
// I can't find "prisoner of azkaban" on google maps (example in class).

// variable types are set before using.
int studentID = 0;
bool validID = false;


// I can't change type of variable, it must store the tyoe declared.
// The commented line below will not work.
//studentID = "34";

// The try keyword says to try this until you get an error (An exception).
// If you get an exception, go do things in the catch block.

while (validID == false)
{
    try
    {
        // Brandon tip: be specific to the user for what you expect.
        Console.Write("What is your student ID number?\t");
        // When I prompt a user, I get a string value back!!!!!
        // We need to try to parse this to make it a int number.
        studentID = int.Parse(Console.ReadLine());
        if (studentID > 0)
        {
            // I've checked to see if the number is "good" (positive)
            validID = true;
        }
        else
        {
            // The number is <1, and is not valid. Make a message, then DO NOT set validId to true.
            Console.WriteLine("Please enter a value GREATER than 0");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("You did not enter a good student id.");
        // This is what your computer gets.
        //Console.WriteLine(ex.ToString());
        // This is a friendly message.
        //Console.WriteLine(ex.Message);
    }
}
// I moved the output OUTSIDE of the loop because I wanted to only see it once.
Console.WriteLine(studentID);
