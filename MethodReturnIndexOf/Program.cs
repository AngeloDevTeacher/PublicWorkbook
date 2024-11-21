const int MaxSize = 50;
int count = 0;


string[] letterArray = new string[MaxSize];

letterArray[0] = "T";
letterArray[1] = "q";
letterArray[2] = "1";
letterArray[3] = "%";
letterArray[4] = "R";
letterArray[5] = "o";
letterArray[6] = "+";
letterArray[7] = "A";

count = 8;

int answer = FindIndexOfFirstVowel(letterArray, count);

Console.WriteLine(answer);

static int FindIndexOfFirstVowel(string[] letters, int logicalSize)
{
    int output = 0;
    int idx = 0;
    string[] vowels = { "a", "e", "i", "o", "u" };
    bool isVowel = false;
    //do
    //{
    //    if (vowels.Contains(letters[idx].ToLower()))
    //    {
    //        output = idx;
    //        isVowel = true;
    //    }
    //    idx++;
    //} while (!isVowel && idx < logicalSize);

    for (int i = 0; i < logicalSize; i++)
    {
        if (vowels.Contains(letters[i].ToLower()) && isVowel == false)
        {
            output = i;
            isVowel = true;
        }
    }
    return output;
}