﻿//Задача 2
//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string difletters = "AAADgch2RTYingh";
Console.WriteLine($"Исходная строка: {difletters}");
string lowerletters = difletters.ToLower();
Console.WriteLine($"Искомая строка: {lowerletters}");