//Задача 1
//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string GetstringfromMatrix (char [,] matrix)
{
    string str = "";
    foreach (char e in matrix)
    str += e;
    return str;
}

char [,] chars = {{'a', 'b', 'c'}, {'d', 'e', 'f'}, {'g', 'h', 'i'}};
string result = GetstringfromMatrix(chars);
Console.WriteLine($"искомая строка из символов массива: {result}");