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


// I can't change type of variable, it must store the tyoe declared.
// The commented line below will not work.
//studentID = "34";


Console.Write("What is your student ID number?\t");
// When I prompt a user, I get a string value back!!!!!
// We need to try to parse this to make it a int number.
studentID = int.Parse(Console.ReadLine());

Console.WriteLine(studentID);