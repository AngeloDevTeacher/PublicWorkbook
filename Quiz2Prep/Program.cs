// Early exit a for loop
string name = "Angelo";
bool foundG = false;
for (int i = 0; i < name.Length && !foundG; i++)
{
    if (name[i] == 'g' || name[i] == 'G')
    { 
        foundG = true;
    }
    Console.WriteLine(name[i]);
}

// Boolean logical (equality or flipping t/f)
// == is equal, a comparison for 2 values
// != not equal, a comparison for 2 values
// ! not, will flip 1 value

// Relational (to compare values, without equality)
// < less than
// > greater than
// <= less than or equals (NOT SPACE IN BETWEEN)
// >= greater than or equals (NOT SPACE IN BETWEEN)

// AND / OR
// && and - both sides MUST BE TRUE for it to be true.
// || or - both sides MUST BE FALSE for it to be false.

bool leverA = false;
bool leverB = false;
if (leverA == true || leverB)
{
    // This is valid code
}

int debit = 4;
int credit = -1000;

// this is wrong
//if (debit || credit > 0)
//{

//}

if (debit > 0 || credit > 0)
{

}

if (false)
{
    // code
}
else if (true)
{
    //code
}
else
{
    //code
}
int dice = 6;
switch (dice)
{
    case 1:
        Console.WriteLine("You rolled a 1");
        break;
    case 2:
        Console.WriteLine("You rolled a 2");
        break;
    case 3:
        Console.WriteLine("You rolled a 3");
        break;
    case 4:
        Console.WriteLine("You rolled a 4");
        break;
    case 5:
        Console.WriteLine("You rolled a 5");
        break;
    case 6:
        Console.WriteLine("You rolled a 6");
        break;

    default:
        Console.WriteLine($"The dice value was not a valid value(1-6), and was instead{dice}");
        break;
}