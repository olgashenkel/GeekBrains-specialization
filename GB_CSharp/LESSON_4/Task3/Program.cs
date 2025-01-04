// Задача 3. Требуется ввести строку с клавиатуры и
// сформировать новую из букв исходной строки.
// ***************
// РЕШЕНИЕ:
// ***************

string GetLettersFromStr(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters += e;
        }
    }
    return letters;
}

string str = Console.ReadLine()!;
string letters = GetLettersFromStr(str);
Console.WriteLine(letters);