string[] rainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

string[] myCopyOfRainbow;

int cash = 100;
int myCash = 0;

myCash = cash;
myCash += 1;
// This line sets myCopy's address to the same as rainbowColors.
//myCopyOfRainbow = rainbowColors;

// Do this to make a new set of data to edit! This also sets myCopy to that address, so I won't have the same mistake!
myCopyOfRainbow = new string[rainbowColors.Length];
rainbowColors.CopyTo(myCopyOfRainbow, 0);

for (int i = 0; i < 7; i++)
{
    myCopyOfRainbow[i] = myCopyOfRainbow[i].ToUpper();
    Console.WriteLine(rainbowColors[i]);
}

// Methods with arrays.
const int Grades_Max_Size = 10;
int[] grades = new int[Grades_Max_Size];

grades[0] = 12;
grades[1] = 26;

static int[] AddGrades(int[] gradesToChange, int amount)
{
    int[] output = new int[gradesToChange.Length];
    for (int i = 0; i < gradesToChange.Length; i++)
    {
        gradesToChange[i] += amount;
        output[i] = gradesToChange[i];
    }
    return output;
}

AddGrades(grades, 6);
Console.WriteLine();


int catCount = 3;
int newCount = 0;
static int AddCats(int currentCount, int addedNumber)
{
    currentCount += addedNumber;
    return currentCount;
}

newCount = AddCats(catCount, 1);
Console.WriteLine(newCount);
Console.WriteLine(catCount);
