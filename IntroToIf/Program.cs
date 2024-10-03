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

if ((haveCats || haveDogs || haveBirds) && haveBunnies)
{
    Console.WriteLine("You are awesome");
}

else
{
    Console.WriteLine("This related code runs when above is FALSE");
}

bool isWendysOk = false;
bool isPrimeTimeDonairOk = true;
bool isMaplePizzaOk = true;
string pattyShape = "circles";

if (isWendysOk == true)
{
    Console.WriteLine("Yay! Let's go on a pilgrimage to Wendys!");
    Console.WriteLine("And go go karting after");
    pattyShape = "square";
}
else if (isPrimeTimeDonairOk == true)
{
    Console.WriteLine("Ok, let's go to Prime Time Donair");
}
else if (isMaplePizzaOk == true)
{
    Console.WriteLine("Sounds awesome, let's go!");
}
else
{
    Console.WriteLine("Dude. Just get something from the fridge, I guess.");
}
