/*

Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

int num = 0;
int ost = 0;
int all = 0;
int temp = 0;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

temp = num; // кидаем первоначальное число во временную переменную temp

while (Convert.ToBoolean(num))
{
    ost = num % 10; // получаем остаток от деления на 10
    num = num / 10; // получаем результат целочисленного деления на 10
    all = all * 10 + ost; // умножаем сумму на 10 и добавляем остаток
}
Console.WriteLine($"-В обратном порядке: {all}");
if (temp == all) // сравнение введенного числа и перевернутого
{
    Console.WriteLine($"Число {all} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {all} не является палиндромом.");
}
*/


/*
Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

int x1 = Location("x", "A");
int y1 = Location("y", "A");
int z1 = Location("z", "A");
int x2 = Location("x", "B");
int y2 = Location("y", "B");
int z2 = Location("z", "B");

int Location(string axisName, string pointName)
{
    Console.Write($"Введите координату {axisName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double FindSqrt(double x1, double x2,  // извлекаем кв. корень из суммы квадратов разниц катетов 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) +
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double Distance =  Math.Round(FindSqrt(x1, x2, y1, y2, z1, z2), 2 );  // округляем до сотых

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {Distance}");
*/


/*
Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
int temp;
Console.Write($"{num} -> ");

while (i <= num)
{
    temp = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($"{temp} ");
    i++;
}
*/