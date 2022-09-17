/*
Console.Clear();

Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int minDigit = Math.Min(numberM,numberN); // узнаем меньшее число

void ShowNumbers(int numberM, int numberN)
{
    int maxDigit = Math.Max(numberM,numberN); // узнаем большее число

    if (minDigit-1 != maxDigit)
    {
        ShowNumbers(minDigit-1, maxDigit-1);
        Console.Write($"{maxDigit}, ");
    }
}

Console.Write($"\nM = {numberM}, N = {numberN} -> \"");
ShowNumbers(numberM, numberN);
Console.Write("\b\b\"\n\n");  // удаление двух последних символов (запятая и пробел), закрытие кавычек и перенос строк
*/



/*
Console.Clear();

Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int minDigit = Math.Min(numberM,numberN); // узнаем меньшее число
int sumDigits = 0;

void ShowNumbers(int numberM, int numberN)
{
    int maxDigit = Math.Max(numberM,numberN); // узнаем большее число

    if (minDigit-1 != maxDigit)
    {
        ShowNumbers(minDigit-1, maxDigit-1);
        Console.Write($"{maxDigit}+");
        sumDigits += maxDigit;
    }
}

Console.Write($"\nM = {numberM}, N = {numberN} -> ");
ShowNumbers(numberM, numberN);
Console.Write($"\b={sumDigits}\n\n");  // удаление двух последних символов (запятая и пробел), закрытие кавычек и перенос строк
*/



/*
Console.Clear();

Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
// m = 2, n = 3 -> A(m,n) = 9
// https://vk.com/@talkcodetome-funkciya-akkermana-post-dlya-teh-kto-sovsem-ne-sechet-v-mate

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckerMan(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckerMan(m - 1, 1);
    else return AckerMan(m - 1, AckerMan(m, n - 1));
}

Console.WriteLine(AckerMan(m, n));
*/