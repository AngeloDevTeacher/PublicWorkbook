/// <summary>
/// Intro to If, else if, and else
/// Author: Angelo Encarnacion - angeloe@nait.ca
/// Date Modified: 2024-10-01
/// </summary>
/// 

int driversAge = 18;
bool passedDriversTest = false;

if ((driversAge >= 18) && passedDriversTest)
{
    Console.WriteLine("You can drive.");
}
else
{
    Console.WriteLine("You cannot drive.");
}

bool haveCats = true;
bool haveDogs = false;
bool haveBirds = false;
bool haveBunnies = false;

if (haveCats || haveDogs || haveBirds && haveBunnies)
{
    Console.WriteLine("You are awesome");
}