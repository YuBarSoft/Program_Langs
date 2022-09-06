/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько целых чисел будет в массиве? ");
int M = Convert.ToInt32(Console.ReadLine());  // определились с длиной массива
int[] array = new int[M];  // объявляем массив на M элементов
int count = 0;  // объявили переменную для счетчика положительных чисел

for (int i=0; i < M; i++)  // проходим по массиву
{
    Console.Write($"Введите число №{i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());  // в i-й элемент запрашиваем значение
    if (array[i] > 0) count++;  // если число больше 0 увеличиваем счетчик на 1
}

// Выводим весь полученный от юзера массив
for (int i=0; i < M; i++)  // опять проходим по массиву
    Console.Write(array[i] + ", ");  // выводим все элементы массива с разделителем (запятая с пробелом)

Console.WriteLine("\b\b -> " + count);  //  удаляем последний разделитель и выводим count
*/


/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
// Console.WriteLine (x);
double y = k1 * x + b1;
// Console.WriteLine (y);

Console.WriteLine ($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
*/