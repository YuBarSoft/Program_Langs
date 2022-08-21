Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вы ввели число {numberA}");

Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вы ввели число {numberB}");

if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
if (numberB > numberA)
{
    Console.WriteLine($"max = {numberB}");
}