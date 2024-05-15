//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

int IsPalindrom (string str)
{
    int counttrue = 0; 
    for (int i = 0; i < str.Length/2; i++)
    {
        if (str[i] == str[str.Length - 1-i])
        {
            counttrue++;
        }
    } 
    return counttrue;
}  

void PrintResult (int count, string str1)
{
    if (count == str1.Length/2)
        Console.Write("Да, данная строка является палиндромом");
    else
        Console.Write("Нет, данная строка не является палиндромом");
}

string difletters = "шалмиЛаш";
Console.WriteLine(difletters);
string newstring = difletters.ToLower();
int count = IsPalindrom(newstring);
PrintResult (count, newstring);
