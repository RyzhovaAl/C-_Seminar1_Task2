// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
double number1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
double number2 = double.Parse(Console.ReadLine()!);
if(number1 > number2)
{
    Console.WriteLine($"{number1} является большим числом, {number2} - меньшим");
}
else
{
    Console.WriteLine($"{number2} является большим числом, {number1} меньшим");
}