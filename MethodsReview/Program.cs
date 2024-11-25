
// private/public/protected are access modifiers
// Static means that it can be accessed "from anywhere".
// int/bool/string/ etc. are return types. void means no return type.
// Add the parenthesis - it helps define this as a method.
string nameFromMainProgram = "Angelo";
Console.WriteLine(LetterCountInName(nameFromMainProgram));
Console.WriteLine(nameFromMainProgram);

int[] numsFromMainProgram = { 10, 20, 30 };
SumNumbersOneMore(numsFromMainProgram);
for (int i = 0; i < numsFromMainProgram.Length; i++)
{
    Console.WriteLine(numsFromMainProgram[i]);
}


static int LetterCountInName(string name)
{
    name = name.Substring(0, 3);
    return name.Length;
}

static void WriteNumberTimes(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(count);
    }
}

static int SumNumbersOneMore(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] += 1;
    }
    return num[0]+num[1]+num[2];
}


static void WriteNumberTimesButNewLines(int count, int that)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(count);
    }
}


int count = 0;

count = LetterCountInName( "Angelo Encarnacion");

//WriteNumberTimes( LetterCountInName("Angelo Encarnacion") );

//double ex = 12.4;
//string output = $"{ex},{ex}";